using Comp123_S1_Group1_L6;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp123_S1_Group1_L9
{
    public partial class CustomerForm : Form
    {

        private bool isNew;

        public Customer customer;
      
        public event EventHandler<CustomerAddedEventArgs> CustomerAdded;
       
        public event EventHandler<CustomerUpdatedEventArgs> CustomerUpdated;
     
        private CustomerRepository customerRepository;
     
        public Customer CustomerToEdit { get; set; }

      
        public CustomerForm(CustomerRepository customerRepository, Customer customer = null)
        {
            InitializeComponent();
            this.customerRepository = customerRepository;
            this.customer = customer;
            if (customer ==  null )
            {
                isNew = true;
            }
            else
            {
                isNew = false;
                // Load data into fields when the form loads
                LoadDataIntoFields();
            }
        }

   
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool success = false;
            if (isNew)
            {
                success =  DoAddCustomer();
            }
            else
            {
                success = DoEditCustomer();
            }
            if (success)
            {
                this.Close();
            }
        }

        private bool DoAddCustomer()
        {
            // Handle adding or editing a customer here
            string customerName = txtCustomerName.Text;
            string customerPhone = txtCustomerPhone.Text;
            //string customerStreet = txtStreet.Text;
            //string[] splitAddress = customerAddress.Split(',');
            Address address = new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPostalCode.Text);
            // ... other information ...



            if (CustomerToEdit == null)
            {
                uint phone = 0;
                // Adding a new customer
                try
                {
                    phone = Convert.ToUInt32(customerPhone);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK);
                    return false;
                }
                customer = new Customer(customerName, phone, address);
                this.customerRepository.Add(customer);
                OnCustomerAdded(customer);
            }
   
            return true;
        }

        private bool DoEditCustomer()
        {
            if (this.customer != null)
            {
                // Update the selectedCustomer with the edited data

                this.customer.Name = txtCustomerName.Text;
                // Assuming CustomerToBeEdited is an instance of a class with an Address property
                this.customer.Address = new Address
                {
                    Street = txtStreet.Text,
                    City = txtCity.Text,
                    Province = txtProvince.Text,
                    PostalCode = txtPostalCode.Text
                };
                try
                {
                    this.customer.Phone = uint.Parse(txtCustomerPhone.Text);
                } 
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid phone number.", "Error", MessageBoxButtons.OK);
                    return false;
                }

                // Set the EditedCustomer property
                // this.customer = selectedCustomer;

                // Notify subscribers that the customer has been updated
                OnCustomerUpdated(this.customer);
                return true;
            }
            return false;
        }

     
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

      
        private void LoadDataIntoFields()
        {
            txtCustomerName.Text = this.customer.Name;
            txtStreet.Text = this.customer.Address.Street;
            txtCity.Text = this.customer.Address.City;
            txtProvince.Text = this.customer.Address.Province;
            txtPostalCode.Text = this.customer.Address.PostalCode;
            txtCustomerPhone.Text = this.customer.Phone.ToString();
            lblTitle.Text = $" Edit customer {this.customer.Name.ToString()}";
        }


        protected virtual void OnCustomerAdded(Customer newCustomer)
        {
            CustomerAdded?.Invoke(this, new CustomerAddedEventArgs(newCustomer));
        }
    
        protected virtual void OnCustomerUpdated(Customer editedCustomer)
        {
            CustomerUpdated?.Invoke(this, new CustomerUpdatedEventArgs(editedCustomer));
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
