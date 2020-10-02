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
    public partial class UserForm : Form
    {

        //Singelton
        HomeBugaltery homeBugaltery = HomeBugaltery.getInstance();

        private Users curentUser;
        private bool IsNewUser = false;

        Users selectUser = null;
        public UserForm(Users curentUser)
        {
            InitializeComponent();

            this.curentUser = curentUser;

            this.Text = homeBugaltery.getFamilyName(curentUser.Family_Id);

            updateUsers();
        }

        private void updateUsers()
        {
            dataGridUsers.Rows.Clear();

            foreach (var user in homeBugaltery.ListUsers)
            {
                var index = dataGridUsers.Rows.Add(user.Email);

                dataGridUsers.Rows[index].Cells[1].Value = user.Name;

                dataGridUsers.Rows[index].Tag = user.Id;
            }
            textBoxEmail.Clear();
            textBoxNik.Clear();
            textBoxParol.Clear();

        }

        private void enabled(bool isEnabled)
        {
            panelNewUser.Enabled = isEnabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" && textBoxEmail.Text != "" && textBoxParol.Text != null)
            {
                MessageBox.Show("Нового користувача не додано!\nПопробуйте ще раз!!!");
                return;
            }

            var message = "";
            if (IsNewUser)
            {
                homeBugaltery.addNewUser(textBoxEmail.Text, textBoxNik.Text, textBoxParol.Text, curentUser.Family_Id);
                message = $"Додано користувача {textBoxEmail.Text}";

                IsNewUser = false;
            }
            else
            {
                homeBugaltery.updateUser(curentUser.Id, textBoxEmail.Text, textBoxNik.Text, textBoxParol.Text);
                message = $"Дані користувача {textBoxEmail.Text} - змінено";
            }

            updateUsers();
            
            MessageBox.Show(message);

          


        }


        private void dataGridUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridUsers.SelectedRows.Count == 0 ||
                (dataGridUsers.SelectedRows.Count == -1 && dataGridUsers.SelectedRows[0].Tag == null)
                || dataGridUsers.SelectedRows[0].Tag == null)
            {
                selectUser = null;
                return;
            }
            var tag = dataGridUsers.SelectedRows[0].Tag;
            int selectUserId = (int)tag;

            selectUser = homeBugaltery.getUserById(selectUserId);



            textBoxEmail.Text = selectUser.Email;
            textBoxNik.Text = selectUser.Name;
            textBoxParol.Text = selectUser.Password;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            labelNewUser.Text = "Обновлення даних користувача :";

           
            textBoxEmail.Text = curentUser.Email;
            textBoxNik.Text = curentUser.Name;
            textBoxParol.Text = curentUser.Password;

            int lastIndex = dataGridUsers.Rows.Count - 1;
            dataGridUsers.Rows[lastIndex].Selected = true;
            dataGridUsers.FirstDisplayedScrollingRowIndex = lastIndex;



        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            labelNewUser.Text = "Новий користувач :";

            //Go to the last ROW in GRID
            int lastIndex = dataGridUsers.Rows.Count - 1;
            dataGridUsers.Rows[lastIndex].Selected = true;
            dataGridUsers.FirstDisplayedScrollingRowIndex = lastIndex;

            textBoxEmail.Clear();
            textBoxNik.Clear();
            textBoxParol.Clear();

            IsNewUser = true;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Видалити? \nВи впевнені?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (dataGridUsers.SelectedRows.Count > 0)
                {
                    try
                    {
                        homeBugaltery.deleteUser(selectUser.Id);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show("Не можливо видалити користувача!!!\nДетально:\n" + exc.Message, "Помилка!!!");
                    }
                }
            }
            else if (result == DialogResult.No)
            {
                return;
            }
            updateUsers();

        }
    }
}
