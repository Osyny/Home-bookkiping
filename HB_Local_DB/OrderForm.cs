using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HB_Local_DB
{
    public partial class OrderForm : Form
    {

        OrdersView currentOrder = null;
        HomeBugaltery homeBugaltery;

        public OrderForm(HomeBugaltery homeBugaltery)
        {
            InitializeComponent();

            this.homeBugaltery = homeBugaltery;
        }

        public void showForm(int orderId = -1)
        {
            currentOrder = homeBugaltery.ListOrders.FirstOrDefault(or => or.Id == orderId);

            updateForm();
            ShowDialog();
        }

        private void updateCategorys()
        {
            comboBoxCategory.Items.Clear();

            foreach(var cat in homeBugaltery.ListCategories)
            {
                comboBoxCategory.Items.Add(cat.Name);
            }
            comboBoxCategory.SelectedIndex = 0;
        }

        private void updateUsers()
        {
            comboBoxUsers.Items.Clear();

            foreach (Users user in homeBugaltery.ListUsers)
            {
                comboBoxUsers.Items.Add(user.Name);
            }
            comboBoxUsers.SelectedIndex = 0;
        }

        private void updateForm()
        {

            updateCategorys();
            updateUsers();

            if (currentOrder != null)
            {
                dateTimePickerOrder.Value = currentOrder.DateOrder;

                comboBoxCategory.SelectedItem = currentOrder.CategoryName;
                comboBoxUsers.SelectedItem = currentOrder.UserName;

                numericUpDownSumm.Value = currentOrder.Price;

                textBoxDescription.Text = currentOrder.Description;

            }
            else
            {
                numericUpDownSumm.Value = 0;
                textBoxDescription.Text = "";
                dateTimePickerOrder.Value = DateTime.Now;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var dateOrder = dateTimePickerOrder.Value;

            var categoryName = comboBoxCategory.SelectedItem.ToString();
            var userName = comboBoxUsers.SelectedItem.ToString();

            var price = numericUpDownSumm.Value;
            var description = textBoxDescription.Text;

            if (comboBoxCategory.SelectedIndex == -1 || comboBoxUsers.SelectedIndex == -1
                || numericUpDownSumm.Value <= 0)
            {
                MessageBox.Show("Cannot add order!\nPlease check inputed data and try again!!!");
                return;
            }
            // edit
            if (currentOrder != null)
            {
                var curentOrderId = currentOrder.Id;
                
                homeBugaltery.changeOrder(curentOrderId, categoryName, userName, dateOrder, price, description);
            }
            else
            {
                 homeBugaltery.addOrder(categoryName, userName, dateOrder, price, description);
            }
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
