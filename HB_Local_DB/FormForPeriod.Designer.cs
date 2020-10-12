namespace HB_Local_DB
{
    partial class FormForPeriod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClouse = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelType = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.dataGridViewEx = new System.Windows.Forms.DataGridView();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Summa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxFilter = new System.Windows.Forms.CheckBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClouse
            // 
            this.btnClouse.Location = new System.Drawing.Point(250, 462);
            this.btnClouse.Name = "btnClouse";
            this.btnClouse.Size = new System.Drawing.Size(75, 23);
            this.btnClouse.TabIndex = 11;
            this.btnClouse.Text = "Закрити";
            this.btnClouse.UseVisualStyleBackColor = true;
            this.btnClouse.Click += new System.EventHandler(this.btnClouse_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.labelType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxSum);
            this.panel1.Controls.Add(this.dataGridViewEx);
            this.panel1.Location = new System.Drawing.Point(12, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 273);
            this.panel1.TabIndex = 12;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelType.Location = new System.Drawing.Point(194, 185);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(0, 20);
            this.labelType.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(89, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Загальна сума :";
            // 
            // textBoxSum
            // 
            this.textBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSum.Location = new System.Drawing.Point(296, 219);
            this.textBoxSum.Multiline = true;
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.Size = new System.Drawing.Size(110, 28);
            this.textBoxSum.TabIndex = 12;
            // 
            // dataGridViewEx
            // 
            this.dataGridViewEx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Category,
            this.UserNames,
            this.Date,
            this.Summa});
            this.dataGridViewEx.Location = new System.Drawing.Point(17, 16);
            this.dataGridViewEx.Name = "dataGridViewEx";
            this.dataGridViewEx.Size = new System.Drawing.Size(545, 175);
            this.dataGridViewEx.TabIndex = 11;
            // 
            // Category
            // 
            this.Category.HeaderText = "Категорія";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // UserNames
            // 
            this.UserNames.HeaderText = "Nik";
            this.UserNames.Name = "UserNames";
            this.UserNames.ReadOnly = true;
            this.UserNames.Width = 200;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 120;
            // 
            // Summa
            // 
            this.Summa.HeaderText = "Сума";
            this.Summa.Name = "Summa";
            this.Summa.ReadOnly = true;
            this.Summa.Width = 80;
            // 
            // panelFilter
            // 
            this.panelFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFilter.Controls.Add(this.label2);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.dateTimePickerTo);
            this.panelFilter.Controls.Add(this.dateTimePickerFrom);
            this.panelFilter.Location = new System.Drawing.Point(93, 31);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(362, 66);
            this.panelFilter.TabIndex = 13;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(15, 29);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(145, 20);
            this.dateTimePickerFrom.TabIndex = 0;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(194, 30);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(144, 20);
            this.dateTimePickerTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Дата від :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дата до :";
            // 
            // checkBoxFilter
            // 
            this.checkBoxFilter.AutoSize = true;
            this.checkBoxFilter.Location = new System.Drawing.Point(107, 9);
            this.checkBoxFilter.Name = "checkBoxFilter";
            this.checkBoxFilter.Size = new System.Drawing.Size(114, 17);
            this.checkBoxFilter.TabIndex = 14;
            this.checkBoxFilter.Text = "Фільтр по датам:";
            this.checkBoxFilter.UseVisualStyleBackColor = true;
            this.checkBoxFilter.CheckedChanged += new System.EventHandler(this.checkBoxFilter_CheckedChanged);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(112, 122);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(327, 26);
            this.buttonFilter.TabIndex = 4;
            this.buttonFilter.Text = "Примінити фільтр";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // FormForPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 553);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.checkBoxFilter);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClouse);
            this.Name = "FormForPeriod";
            this.Text = "FormForPeriod";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEx)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClouse;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.DataGridView dataGridViewEx;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Summa;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.CheckBox checkBoxFilter;
    }
}