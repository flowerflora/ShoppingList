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
            if (String.IsNullOrEmpty(NameTxt.Text)) MessageBox.Show("Please Enter Item Name");
            else
            {
                /*ShopList.Columns.add("Name");
                ShopList.BeginUpdate();
                ShopList.Items.Add(NameTxt.Text);
                ShopList.EndUpdate();*/
                ShopDG.Rows.Add(NameTxt.Text,PriceTxt.Text);
            }
        }

        private void StarBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTxt.Text)) MessageBox.Show("Please Enter Item Name");
            else
            {
                RecDG.Rows.Add(NameTxt.Text, PriceTxt.Text);
            }

        }

        private void RemovBtn_Click(object sender, EventArgs e)
        {

        }

        private void CloseBtn_Click(object sender, EventArgs e) { this.Dispose(); }
    }
}
