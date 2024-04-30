namespace data_to_exel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveBtn = new Button();
            LstvContentData = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SaveArrayBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NamePdrocutTxt = new TextBox();
            QuantityNud = new NumericUpDown();
            PriseNud = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)QuantityNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PriseNud).BeginInit();
            SuspendLayout();
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(69, 410);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(148, 28);
            SaveBtn.TabIndex = 0;
            SaveBtn.Text = " Save Data Of File Text";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // LstvContentData
            // 
            LstvContentData.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            LstvContentData.Location = new Point(283, 12);
            LstvContentData.Name = "LstvContentData";
            LstvContentData.Size = new Size(505, 426);
            LstvContentData.TabIndex = 1;
            LstvContentData.UseCompatibleStateImageBehavior = false;
            LstvContentData.View = View.Details;
            LstvContentData.SelectedIndexChanged += LstvContentData_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Producto";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cantidad";
            columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Pecio total";
            columnHeader3.Width = 120;
            // 
            // SaveArrayBtn
            // 
            SaveArrayBtn.Location = new Point(94, 196);
            SaveArrayBtn.Name = "SaveArrayBtn";
            SaveArrayBtn.Size = new Size(95, 23);
            SaveArrayBtn.TabIndex = 2;
            SaveArrayBtn.Text = "Save";
            SaveArrayBtn.UseVisualStyleBackColor = true;
            SaveArrayBtn.Click += SaveArrayBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 52);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Name of The Product";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 95);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 4;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 143);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Prise for one product";
            // 
            // NamePdrocutTxt
            // 
            NamePdrocutTxt.Location = new Point(145, 49);
            NamePdrocutTxt.Name = "NamePdrocutTxt";
            NamePdrocutTxt.Size = new Size(120, 23);
            NamePdrocutTxt.TabIndex = 6;
            // 
            // QuantityNud
            // 
            QuantityNud.Location = new Point(145, 87);
            QuantityNud.Name = "QuantityNud";
            QuantityNud.Size = new Size(120, 23);
            QuantityNud.TabIndex = 7;
            // 
            // PriseNud
            // 
            PriseNud.Location = new Point(145, 135);
            PriseNud.Name = "PriseNud";
            PriseNud.Size = new Size(120, 23);
            PriseNud.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PriseNud);
            Controls.Add(QuantityNud);
            Controls.Add(NamePdrocutTxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SaveArrayBtn);
            Controls.Add(LstvContentData);
            Controls.Add(SaveBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)QuantityNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)PriseNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SaveBtn;
        private ListView LstvContentData;
        private Button SaveArrayBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NamePdrocutTxt;
        private NumericUpDown QuantityNud;
        private NumericUpDown PriseNud;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}
