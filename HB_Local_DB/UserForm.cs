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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectUser == null)
            {
                homeBugaltery.addNewUser(textBoxEmail.Text, textBoxNik.Text, textBoxParol.Text, curentUser.Family_Id);
            }
            else
            {
                homeBugaltery.updateUser(selectUser.Id, textBoxEmail.Text, textBoxNik.Text, textBoxParol.Text);
            }
        }

       
        private void dataGridUsers_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridUsers.SelectedRows.Count == 0 && dataGridUsers.SelectedRows[0].Tag == null)
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
            selectUser.Email = textBoxEmail.Text;
            selectUser.Name = textBoxNik.Text;
            selectUser.Password = textBoxParol.Text;

           
         //   updateUsers();
           //te.Clear();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            //Go to the last ROW in GRID
            int lastIndex = dataGridUsers.Rows.Count - 1;
            dataGridUsers.Rows[lastIndex].Selected = true;
            dataGridUsers.FirstDisplayedScrollingRowIndex = lastIndex;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
