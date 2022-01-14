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
            string _file = string.Empty;
            OpenFileDialog openDialog = new OpenFileDialog();

            //Set Tile of OpenFileDialog
            openDialog.Title = "Select An Excel File";

            //Set the File Filter of OpenFileDialog
            openDialog.Filter = "Excel 7.0 (*.xlsx)|*.xlsx" + "|" +
                                "Excel (*.xls)|*.xls" + "|" +
                                "CSV (*.csv)|*.csv" + "|" +
                                "All Files (*.*)|*.*";

            //Get the OK press of the Dialog Box
            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                //Get Selected File
                _file = openDialog.FileName;
                this.txtFile.Text = _file;
            }
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
                { ShopDG.Rows.Add(rows2);  ItemsDG.Rows.Remove(rows2);}
            }
            else if(String.IsNullOrEmpty(NameTxt.Text)) MessageBox.Show("Please Enter Item Name");
            else
            {
                ShopDG.Rows.Add(NameTxt.Text,PriceTxt.Text,1);
                //find object, if no object, make new one, add to list
                //update list
                 List<int[]> addition = new List<int[]>(); addition.Add(Date.Text.Split('/').Select(Int32.Parse).ToArray());
                Item adding = new ShoppingList.Item(addition , Convert.ToDouble(PriceTxt.Text), NameTxt.Text, false);
                for (int i=0; i < (Data.Data.Rows).Count; i++)
                {
                    if (NameTxt.Text.Equals(ItemsDG.Columns[0][i]))
                    {
                         adding =ItemsDG.Columns[0][i]; 
                        break;
                    }
                    
                }
            }
        }

        private void StarBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(NameTxt.Text)) MessageBox.Show("Please Enter Item Name");
            else
            {
                RecDG.Rows.Add(NameTxt.Text, PriceTxt.Text);
                //find object, if no object, make new one, add star
                List<int[]> addition = new List<int[]>(); addition.Add(Date.Text.Split('/').Select(Int32.Parse).ToArray());
                Item adding = new ShoppingList.Item(addition, Convert.ToDouble(PriceTxt.Text), NameTxt.Text, true);
                for (int i = 0; i < (Data.Data.Rows).Count; i++)
                {
                    if (NameTxt.Text.Equals(ItemsDG.Columns[0][i]))
                    {
                        adding = ItemsDG.Columns[0][i];
                        break;
                    }

                } adding.StarItem();
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

        private void CloseBtn_Click(object sender, EventArgs e) {
            this.Dispose();
        //update database with shopping list
        }

        private void RmStarBtn_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection row = RecDG.SelectedRows;
            foreach (DataGridViewRow rows in row)
                RecDG.Rows.Remove(rows);
        }
    }
}
