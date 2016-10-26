using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PoppelProject.BusinessLayer;

namespace PoppelProject.PresentationLayer
{
    public partial class PickingListForm : Form
    {
        #region Attributes
        public bool listFormClosed = false;
        private OrderItemsController orderItemsController;
        private CustomerController customerController;
        private ProductController productController;
        private OrderController orderController;
        private Order order;

       // private OrderItems orderItem;
        private Collection<OrderItems> orderItems;
        //private FormStates state;

        #endregion

        #region Constructor
        public PickingListForm(ProductController aProductController, CustomerController aCustomerController)
        {
            InitializeComponent();
            productController = aProductController;
            customerController = aCustomerController;
            orderItemsController = new OrderItemsController();
            orderController = new OrderController() ;
            FillCombo();
            ItemsListView();
            HideAll(false);
        }
        #endregion

        #region Form events
        private void PickingListForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            listFormClosed = true;
        }

        #endregion

        #region Button Clicked Events
        private void doneButton_Click(object sender, EventArgs e)  // To finiliz that an order has been picked
        {
            if (order != null)
            {   
                //Ask user if they want to confirm order
                if (MessageBox.Show("Are you sure you want to confirm order as picked?", "Confirming Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Here we change the order status to be picked and clear the picking list
                    order.OrderValue = Order.OrderStatus.picked;
                    orderController.DataMaintenance(order, DatabaseLayer.DB.DBOperation.Edit);

                    if (orderController.FinalizeChanges(order) == true)
                    {
                        ordersComboBox.Items.Remove(ordersComboBox.SelectedItem); //remove item from combo box when picked
                    }

                    orderController.FinalizeChanges(order);
                    orderItemsListView.Clear();
                    ItemsListView();
                    orderItemsListView.Refresh();
                    ordersComboBox.SelectedIndex = -1;
                    ordersComboBox.Text = "";
                    order = null;
                    HideAll(false);

                }
                else
                {
                    this.Activate();
                }
            }

            else
            {
                MessageBox.Show("Cannot finilaze a order without generating a order list");
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close form?", "Closing form", MessageBoxButtons.YesNo) == DialogResult.Yes)
            { this.Close(); }
        }

        private void okButton_Click(object sender, EventArgs e)   // Selecting an item from the combo box
        {
            order = default(Order);
            order = (Order)ordersComboBox.SelectedItem;

            //Cannot create a list id no order is selected
            if (order == null)
            {
                MessageBox.Show("First select an order to generate a picking list");
            }

            else
            {
                orderDateTextBox.Text = Convert.ToString(order.OrderDate);
                Customer customer = customerController.Find(order.CustomerID);
                CustomerIDTextBox.Text = customer.CustomerID ;
                CustomerNameTextBox.Text = customer.Name + " " + customer.Surname;
                CustomerAddressTextBox.Text = customer.CustomerAddress;
                HideAll(true);
                ItemsListView();
            }
        }
        #endregion

        #region Methods
        public void HideAll(bool value)
        {
            orderDateTextBox.Visible = value;
            CustomerIDTextBox.Visible = value;
            CustomerNameTextBox.Visible = value;
            CustomerAddressTextBox.Visible = value;
     
        }
        public void FillCombo()
        {
             Collection<Order> orders = new Collection<Order>();
             orderController = new OrderController();
             orders = orderController.FindByStatus(Order.OrderStatus.unpicked); 
             //Link the objects in the collection of unpicked orders to every item of the combo box
             foreach (Order eachOrder in orders)
             {
                 ordersComboBox.Items.Add(eachOrder);
             }

             // Allow to search on combo box
            ordersComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ordersComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            //Set the current display of the combobox to nothing
            ordersComboBox.SelectedIndex = -1;
            ordersComboBox.Text = "";
        }
        
        public void ItemsListView()
        {
            ListViewItem itemDetails;
           // order = new Order();
            order = (Order)ordersComboBox.SelectedItem;   // reading from the combo box
            orderItemsListView.Clear();

            if (order == null)  // If nothing has been selected yet on the combo box
            {
                //Set Up Columns of List View
                orderItemsListView.View = View.Details;
                orderItemsListView.Columns.Insert(0, "Product ID", 133, HorizontalAlignment.Left);
                orderItemsListView.Columns.Insert(1, "Product Name", 140, HorizontalAlignment.Left);
                orderItemsListView.Columns.Insert(2, "Quantity", 133, HorizontalAlignment.Left);
            }

            else
            {
                orderItemsListView.View = View.Details;
                orderItemsListView.Columns.Insert(0, "Product ID", 133, HorizontalAlignment.Left);
                orderItemsListView.Columns.Insert(1, "Product Name", 140, HorizontalAlignment.Left);
                orderItemsListView.Columns.Insert(2, "Quantity", 133, HorizontalAlignment.Left);

                orderItems = null;  //employees collection will be filled by role
                orderItems = orderItemsController.FindByOrderID(order.OrderID);

                //Add item details to each ListView item 
                foreach (OrderItems item in orderItems)
                {
                    Product product = productController.Find(item.ProductID);  // get the selected product details
                    itemDetails = new ListViewItem();
                    itemDetails.Text = item.ProductID.ToString();
                    itemDetails.SubItems.Add(product.ProductName);
                    itemDetails.SubItems.Add(item.Quantity.ToString());
                    orderItemsListView.Items.Add(itemDetails);
                }
            }

            orderItemsListView.Refresh();
            orderItemsListView.GridLines = true;
        }

        #endregion

    }
}
