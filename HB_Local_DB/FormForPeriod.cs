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
    public partial class FormForPeriod : Form
    {
        //Singelton
        HomeBugaltery homeBugaltery = HomeBugaltery.getInstance();

        bool isProfit;
        decimal sum;
        public FormForPeriod(bool isProfit)
        {
            InitializeComponent();

            this.isProfit = isProfit;


            if (isProfit == false)
                this.Text = "Витрати за період";
            else
                this.Text = "Доходи за період";

            if (isProfit == false)
                labelType.Text = "витрат : ";
            else
                labelType.Text = "доходів : ";

            sum = homeBugaltery.applyFiltersForCostsProfit(isProfit);

            panelFilter.Enabled = checkBoxFilter.Checked;

            updateForm();
        }

        private void updateForm()
        {
            dataGridViewEx.Rows.Clear();
           
            foreach(var ord in homeBugaltery.OrderCostsProfitList)
            {
                var index = dataGridViewEx.Rows.Add(ord.CategoryName);

                dataGridViewEx.Rows[index].Cells[1].Value = ord.UserName;
                dataGridViewEx.Rows[index].Cells[2].Value = ord.DateOrder;
                dataGridViewEx.Rows[index].Cells[3].Value = ord.Price;

                dataGridViewEx.Rows[index].Tag = ord.Id;
                textBoxSum.Text = sum.ToString();
            }
            textBoxSum.Text = sum.ToString();
        }

     
        private void checkBoxFilter_CheckedChanged(object sender, EventArgs e)
        {
            panelFilter.Enabled = checkBoxFilter.Checked;
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (checkBoxFilter.Checked)
                sum = homeBugaltery.applyFiltersForCostsProfit(isProfit, dateTimePickerFrom.Value, dateTimePickerTo.Value);
            else
                sum = homeBugaltery.applyFiltersForCostsProfit(isProfit);

            updateForm();
        }


        private void btnClouse_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
