
namespace ShoppingList
{
    partial class MenuForm
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
            this.AddItemBtn = new System.Windows.Forms.Button();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // AddItemBtn
            // 
            this.AddItemBtn.Location = new System.Drawing.Point(646, 19);
            this.AddItemBtn.Name = "AddItemBtn";
            this.AddItemBtn.Size = new System.Drawing.Size(139, 70);
            this.AddItemBtn.TabIndex = 0;
            this.AddItemBtn.Text = "Add Items";
            this.AddItemBtn.UseVisualStyleBackColor = true;
            this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Location = new System.Drawing.Point(646, 138);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(139, 80);
            this.PrevBtn.TabIndex = 1;
            this.PrevBtn.Text = "Previously Bought Items";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(646, 400);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(139, 38);
            this.CloseBtn.TabIndex = 2;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Calendar
            // 
            this.Calendar.Location = new System.Drawing.Point(19, 24);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 3;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Calendar);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.AddItemBtn);
            this.Name = "MenuForm";
            this.Text = "Menu Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddItemBtn;
        private System.Windows.Forms.Button PrevBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.MonthCalendar Calendar;
    }
}

