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
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent(); this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void AddStarBtn_Click(object sender, EventArgs e)
        {

        }

        private void RemStarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = ItemDG.SelectedRows;
            foreach(DataGridViewRow rows in row)
            ItemDG.Rows.Remove(rows);
        }

        private void CloseBtn_Click(object sender, EventArgs e) { this.Dispose(); }
    }
}
