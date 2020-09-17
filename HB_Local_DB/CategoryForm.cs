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
    public partial class CategoryForm : Form
    {
        HomeBugaltery homeBugaltery = HomeBugaltery.getInstance();
        Categories curentCategory = null;
        public CategoryForm()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;

            updateCatergory();
        }

        private void updateCatergory()
        {
            dataGridViewCategory.Rows.Clear();
            var categoryList = homeBugaltery.ListCategories;

            var typeName = "";
            foreach(var cat in categoryList)
            {
                if (cat.Type)
                    typeName = "прихід";
                else
                    typeName = "розхід";

                int rowIndex = dataGridViewCategory.Rows.Add(cat.Name);

                dataGridViewCategory.Rows[rowIndex].Cells[1].Value = typeName;

                //Tag - id category
                dataGridViewCategory.Rows[rowIndex].Tag = cat.Id;
            }
        }

        //Go to the last ROW in GRID
        private void btnNewCategory_Click(object sender, EventArgs e)
        {
            labelAddEdit.Text = "Добавити нову категорію";

            int lastIndex = dataGridViewCategory.Rows.Count - 1;
            dataGridViewCategory.Rows[lastIndex].Selected = true;

            dataGridViewCategory.FirstDisplayedScrollingRowIndex = lastIndex;
        }

        private void dataGridViewCategory_SelectionChanged(object sender, EventArgs e)
        {
            //var row = dataGridViewCategory.Rows[dataGridViewCategory.SelectedCells[0].RowIndex];

            if (dataGridViewCategory.SelectedRows.Count == 0 || dataGridViewCategory.SelectedRows[0].Tag == null)
            {

                labelAddEdit.Text = "Додати нову категорію :";

                textBoxNewCategory.ReadOnly = false;

                textBoxNewCategory.Text = "";
                comboBoxType.SelectedIndex = -1;
                curentCategory = null;
                return;
            }

            labelAddEdit.Text = "Редагувати категорію :";

            var tag = dataGridViewCategory.SelectedRows[0].Tag;
            int curentCategoryId = (int)tag;

            curentCategory = homeBugaltery.ListCategories.FirstOrDefault(cat => cat.Id == curentCategoryId);

            textBoxNewCategory.Text = curentCategory.Name;

            if (curentCategory.Type == false)
                comboBoxType.SelectedIndex = 0;
            else
                comboBoxType.SelectedIndex = 1;

        }

            private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool type = false;
            if (comboBoxType.SelectedIndex == 1)
                type = true;

            var categoryName = textBoxNewCategory.Text;

            // Add New Category
            if (curentCategory == null)
            {            
                homeBugaltery.addCategory(categoryName, type);            
            }
            else
            {
                homeBugaltery.changeCategory(curentCategory.Id, categoryName, type);
            }
            updateCatergory();
            textBoxNewCategory.Clear();
           
        }
        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
