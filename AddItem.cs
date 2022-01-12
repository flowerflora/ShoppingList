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
    public partial class AddItem : Form
    {
        public AddItem()
        {
            InitializeComponent(); this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            PriceTxt.Text = "0";
        }

        private void ImpBtn_Click(object sender, EventArgs e)
        {

        }

        private void ExpBtn_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (RecDG.SelectedRows == null || ItemsDG.SelectedRows == null)
            {
                DataGridViewSelectedRowCollection row = RecDG.SelectedRows;
                foreach (DataGridViewRow rows in row)
                { ShopDG.Rows.Add(rows); RecDG.Rows.Remove(rows); }
                DataGridViewSelectedRowCollection row2 = ItemsDG.SelectedRows;
                foreach (DataGridViewRow rows2 in row2)
                { ShopDG.Rows.Add(rows2); ItemsDG.Rows.Remove(rows2); }
            }
            else if(String.IsNullOrEmpty(NameTxt.Text)) MessageBox.Show("Please Enter Item Name");
            else
            {
                ShopDG.Rows.Add(NameTxt.Text,PriceTxt.Text,1);
                //find object, if no object, make new one, add to list
                //update list
            }
        }

        private void StarBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTxt.Text)) MessageBox.Show("Please Enter Item Name");
            else
            {
                RecDG.Rows.Add(NameTxt.Text, PriceTxt.Text);
                //find object, if no object, make new one, add star
                //update list
            }

        }

        private void RemovBtn_Click(object sender, EventArgs e)
        {
           //removing seleted rows in shop
           DataGridViewSelectedRowCollection row = ShopDG.SelectedRows;
            foreach (DataGridViewRow rows in row)
            { ShopDG.Rows.Remove(rows); ItemsDG.Rows.Add(rows); }
        }

        private void CloseBtn_Click(object sender, EventArgs e) { this.Dispose(); }

        private void RmStarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = RecDG.SelectedRows;
            foreach (DataGridViewRow rows in row)
                RecDG.Rows.Remove(rows);
        }
    }
}
