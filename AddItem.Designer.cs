
namespace ShoppingList
{
    partial class AddItem
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ImpBtn = new System.Windows.Forms.Button();
            this.ExpBtn = new System.Windows.Forms.Button();
            this.ShopList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RecList = new System.Windows.Forms.ListBox();
            this.ItemList = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.StarBtn = new System.Windows.Forms.Button();
            this.RemovBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(13, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date";
            // 
            // ImpBtn
            // 
            this.ImpBtn.Location = new System.Drawing.Point(279, 21);
            this.ImpBtn.Name = "ImpBtn";
            this.ImpBtn.Size = new System.Drawing.Size(158, 27);
            this.ImpBtn.TabIndex = 2;
            this.ImpBtn.Text = "Import List";
            this.ImpBtn.UseVisualStyleBackColor = true;
            this.ImpBtn.Click += new System.EventHandler(this.ImpBtn_Click);
            // 
            // ExpBtn
            // 
            this.ExpBtn.Location = new System.Drawing.Point(478, 21);
            this.ExpBtn.Name = "ExpBtn";
            this.ExpBtn.Size = new System.Drawing.Size(178, 27);
            this.ExpBtn.TabIndex = 3;
            this.ExpBtn.Text = "Export List";
            this.ExpBtn.UseVisualStyleBackColor = true;
            this.ExpBtn.Click += new System.EventHandler(this.ExpBtn_Click);
            // 
            // ShopList
            // 
            this.ShopList.AllowDrop = true;
            this.ShopList.BackColor = System.Drawing.SystemColors.Window;
            this.ShopList.FormattingEnabled = true;
            this.ShopList.HorizontalScrollbar = true;
            this.ShopList.Location = new System.Drawing.Point(12, 90);
            this.ShopList.Name = "ShopList";
            this.ShopList.Size = new System.Drawing.Size(643, 199);
            this.ShopList.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shopping List";
            // 
            // RecList
            // 
            this.RecList.FormattingEnabled = true;
            this.RecList.HorizontalScrollbar = true;
            this.RecList.Location = new System.Drawing.Point(12, 330);
            this.RecList.Name = "RecList";
            this.RecList.Size = new System.Drawing.Size(301, 199);
            this.RecList.TabIndex = 6;
            // 
            // ItemList
            // 
            this.ItemList.FormattingEnabled = true;
            this.ItemList.Location = new System.Drawing.Point(331, 330);
            this.ItemList.Name = "ItemList";
            this.ItemList.Size = new System.Drawing.Size(324, 199);
            this.ItemList.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recommended Items";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Previously Bought Items";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(15, 620);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(94, 37);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add Item";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // StarBtn
            // 
            this.StarBtn.Location = new System.Drawing.Point(132, 617);
            this.StarBtn.Name = "StarBtn";
            this.StarBtn.Size = new System.Drawing.Size(81, 40);
            this.StarBtn.TabIndex = 11;
            this.StarBtn.Text = "Star Item";
            this.StarBtn.UseVisualStyleBackColor = true;
            this.StarBtn.Click += new System.EventHandler(this.StarBtn_Click);
            // 
            // RemovBtn
            // 
            this.RemovBtn.Location = new System.Drawing.Point(230, 617);
            this.RemovBtn.Name = "RemovBtn";
            this.RemovBtn.Size = new System.Drawing.Size(83, 38);
            this.RemovBtn.TabIndex = 12;
            this.RemovBtn.Text = "Remove Item";
            this.RemovBtn.UseVisualStyleBackColor = true;
            this.RemovBtn.Click += new System.EventHandler(this.RemovBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(586, 616);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(69, 36);
            this.CloseBtn.TabIndex = 13;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // NameTxt
            // 
            this.NameTxt.Location = new System.Drawing.Point(15, 577);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.Size = new System.Drawing.Size(168, 20);
            this.NameTxt.TabIndex = 14;
            this.NameTxt.Text = "Enter Item Name";
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(207, 574);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(180, 20);
            this.PriceTxt.TabIndex = 15;
            this.PriceTxt.Text = "Enter Item Price";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 669);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RemovBtn);
            this.Controls.Add(this.StarBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ItemList);
            this.Controls.Add(this.RecList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShopList);
            this.Controls.Add(this.ExpBtn);
            this.Controls.Add(this.ImpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "AddItem";
            this.Text = "Add Items";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImpBtn;
        private System.Windows.Forms.Button ExpBtn;
        private System.Windows.Forms.ListBox ShopList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox RecList;
        private System.Windows.Forms.ListBox ItemList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button StarBtn;
        private System.Windows.Forms.Button RemovBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox PriceTxt;
    }
}