using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingList
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent(); this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Calendar.Scale(2, 2);
        }

        private void AddItemBtn_Click(object sender, EventArgs e)
        {
            AddItem frmAdd = new AddItem(); //Show the form
            frmAdd.ShowDialog();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            ItemsForm frmItem = new ItemsForm(); //Show the form
            frmItem.ShowDialog();
        }

        private void CloseBtn_Click(object sender, EventArgs e) {this.Dispose();}
    }
}
