
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
            this.ItemsList = new System.Windows.Forms.ListBox();
            this.AddStarBtn = new System.Windows.Forms.Button();
            this.RemStarBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
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
            // ItemsList
            // 
            this.ItemsList.FormattingEnabled = true;
            this.ItemsList.HorizontalScrollbar = true;
            this.ItemsList.Location = new System.Drawing.Point(12, 26);
            this.ItemsList.Name = "ItemsList";
            this.ItemsList.Size = new System.Drawing.Size(572, 407);
            this.ItemsList.TabIndex = 1;
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
            // ItemsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 522);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.RemStarBtn);
            this.Controls.Add(this.AddStarBtn);
            this.Controls.Add(this.ItemsList);
            this.Controls.Add(this.label1);
            this.Name = "ItemsForm";
            this.Text = "Items Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ItemsList;
        private System.Windows.Forms.Button AddStarBtn;
        private System.Windows.Forms.Button RemStarBtn;
        private System.Windows.Forms.Button CloseBtn;
    }
}