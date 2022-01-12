
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
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ImpBtn = new System.Windows.Forms.Button();
            this.ExpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.StarBtn = new System.Windows.Forms.Button();
            this.RemovBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.PriceTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ItemsDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecDG = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShopDG = new System.Windows.Forms.DataGridView();
            this.RmStarBtn = new System.Windows.Forms.Button();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDG)).BeginInit();
            this.SuspendLayout();
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(13, 28);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(242, 20);
            this.Date.TabIndex = 0;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Shopping List";
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
            this.label4.Location = new System.Drawing.Point(338, 312);
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
            this.StarBtn.Location = new System.Drawing.Point(232, 619);
            this.StarBtn.Name = "StarBtn";
            this.StarBtn.Size = new System.Drawing.Size(81, 40);
            this.StarBtn.TabIndex = 11;
            this.StarBtn.Text = "Star Item";
            this.StarBtn.UseVisualStyleBackColor = true;
            this.StarBtn.Click += new System.EventHandler(this.StarBtn_Click);
            // 
            // RemovBtn
            // 
            this.RemovBtn.Location = new System.Drawing.Point(128, 619);
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
            // 
            // PriceTxt
            // 
            this.PriceTxt.Location = new System.Drawing.Point(207, 574);
            this.PriceTxt.Name = "PriceTxt";
            this.PriceTxt.Size = new System.Drawing.Size(180, 20);
            this.PriceTxt.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter Item Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Enter Item Price";
            // 
            // ItemsDG
            // 
            this.ItemsDG.AllowUserToResizeColumns = false;
            this.ItemsDG.AllowUserToResizeRows = false;
            this.ItemsDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.ItemsDG.Location = new System.Drawing.Point(341, 330);
            this.ItemsDG.Name = "ItemsDG";
            this.ItemsDG.Size = new System.Drawing.Size(314, 202);
            this.ItemsDG.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Item";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Price";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // RecDG
            // 
            this.RecDG.AllowUserToResizeColumns = false;
            this.RecDG.AllowUserToResizeRows = false;
            this.RecDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RecDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.RecDG.Location = new System.Drawing.Point(12, 330);
            this.RecDG.Name = "RecDG";
            this.RecDG.Size = new System.Drawing.Size(301, 202);
            this.RecDG.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Item";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // ShopDG
            // 
            this.ShopDG.AllowUserToResizeColumns = false;
            this.ShopDG.AllowUserToResizeRows = false;
            this.ShopDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ShopDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShopDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Price,
            this.Count});
            this.ShopDG.Location = new System.Drawing.Point(12, 94);
            this.ShopDG.Name = "ShopDG";
            this.ShopDG.Size = new System.Drawing.Size(643, 202);
            this.ShopDG.TabIndex = 18;
            // 
            // RmStarBtn
            // 
            this.RmStarBtn.Location = new System.Drawing.Point(340, 620);
            this.RmStarBtn.Name = "RmStarBtn";
            this.RmStarBtn.Size = new System.Drawing.Size(77, 36);
            this.RmStarBtn.TabIndex = 21;
            this.RmStarBtn.Text = "Remove Star";
            this.RmStarBtn.UseVisualStyleBackColor = true;
            this.RmStarBtn.Click += new System.EventHandler(this.RmStarBtn_Click);
            // 
            // Count
            // 
            this.Count.HeaderText = "Count";
            this.Count.Name = "Count";
            // 
            // AddItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 669);
            this.Controls.Add(this.RmStarBtn);
            this.Controls.Add(this.RecDG);
            this.Controls.Add(this.ItemsDG);
            this.Controls.Add(this.ShopDG);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PriceTxt);
            this.Controls.Add(this.NameTxt);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RemovBtn);
            this.Controls.Add(this.StarBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExpBtn);
            this.Controls.Add(this.ImpBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Name = "AddItem";
            this.Text = "Add Items";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecDG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShopDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ImpBtn;
        private System.Windows.Forms.Button ExpBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button StarBtn;
        private System.Windows.Forms.Button RemovBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.TextBox PriceTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ItemsDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView RecDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridView ShopDG;
        private System.Windows.Forms.Button RmStarBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
    }
}