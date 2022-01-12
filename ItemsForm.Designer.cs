
namespace ShoppingList
{
    partial class ItemsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.AddStarBtn = new System.Windows.Forms.Button();
            this.RemStarBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.ItemDG = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ItemDG)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Items List";
            // 
            // AddStarBtn
            // 
            this.AddStarBtn.Location = new System.Drawing.Point(21, 454);
            this.AddStarBtn.Name = "AddStarBtn";
            this.AddStarBtn.Size = new System.Drawing.Size(109, 25);
            this.AddStarBtn.TabIndex = 2;
            this.AddStarBtn.Text = "Add Star";
            this.AddStarBtn.UseVisualStyleBackColor = true;
            this.AddStarBtn.Click += new System.EventHandler(this.AddStarBtn_Click);
            // 
            // RemStarBtn
            // 
            this.RemStarBtn.Location = new System.Drawing.Point(168, 457);
            this.RemStarBtn.Name = "RemStarBtn";
            this.RemStarBtn.Size = new System.Drawing.Size(114, 21);
            this.RemStarBtn.TabIndex = 3;
            this.RemStarBtn.Text = "Remove Star";
            this.RemStarBtn.UseVisualStyleBackColor = true;
            this.RemStarBtn.Click += new System.EventHandler(this.RemStarBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(512, 457);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(72, 22);
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // ItemDG
            // 
            this.ItemDG.AllowUserToResizeColumns = false;
            this.ItemDG.AllowUserToResizeRows = false;
            this.ItemDG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemDG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.Price});
            this.ItemDG.Location = new System.Drawing.Point(13, 26);
            this.ItemDG.Name = "ItemDG";
            this.ItemDG.Size = new System.Drawing.Size(571, 422);
            this.ItemDG.TabIndex = 19;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 522);
            this.Controls.Add(this.ItemDG);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RemStarBtn);
            this.Controls.Add(this.AddStarBtn);
            this.Controls.Add(this.label1);
            this.Name = "ItemsForm";
            this.Text = "Items Form";
            ((System.ComponentModel.ISupportInitialize)(this.ItemDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddStarBtn;
        private System.Windows.Forms.Button RemStarBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.DataGridView ItemDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}