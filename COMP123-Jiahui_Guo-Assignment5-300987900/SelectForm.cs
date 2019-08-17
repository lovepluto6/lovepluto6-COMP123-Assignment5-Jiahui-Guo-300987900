using COMP123_Jiahui_Guo_Assignment5_300987900.Sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Jiahui_Guo_Assignment5_300987900
{
    public partial class SelectForm : Form
    {
        public SelectForm()
        {
            InitializeComponent();
        }

        private void SelectForm_Load(object sender, EventArgs e)
        {
            using (var db =new DollarComputerContext())
            {
                db.products.Load();
                productsBindingSource.DataSource = db.products.Local.ToBindingList();
            }
        }

        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }

        private void ProductDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void ProductDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = ProductDataGridView.CurrentCell.RowIndex;
            var rows = ProductDataGridView.Rows;
            var columnCount = ProductDataGridView.ColumnCount;
            var cells = rows[rowIndex].Cells;

            rows[rowIndex].Selected = true;

            Program.products.productID = short.Parse(cells[0].Value.ToString());
            Program.products.cost = decimal.Parse(cells[1].Value.ToString());
            Program.products.manufacturer = cells[2].Value.ToString();
            Program.products.model = cells[3].Value.ToString();
            Program.products.RAM_type = cells[4].Value.ToString();
            Program.products.RAM_size = cells[5].Value.ToString();
            Program.products.displaytype = cells[6].Value.ToString();
            Program.products.screensize = cells[7].Value.ToString();
            Program.products.resolution = cells[8].Value.ToString();
            Program.products.CPU_Class = cells[9].Value.ToString();
            Program.products.CPU_brand = cells[10].Value.ToString();
            Program.products.CPU_type = cells[11].Value.ToString();
            Program.products.CPU_speed = cells[12].Value.ToString();
            Program.products.CPU_number = cells[13].Value.ToString();
            Program.products.condition = cells[14].Value.ToString();
            Program.products.OS = cells[15].Value.ToString();
            Program.products.platform = cells[16].Value.ToString();
            Program.products.HDD_size = cells[17].Value.ToString();
            Program.products.HDD_speed = cells[18].Value.ToString();
            Program.products.GPU_Type = cells[19].Value.ToString();
            Program.products.optical_drive = cells[20].Value.ToString();
            Program.products.Audio_type = cells[21].Value.ToString();
            Program.products.LAN = cells[22].Value.ToString();
            Program.products.WIFI = cells[23].Value.ToString();
            Program.products.width = cells[24].Value.ToString();
            Program.products.height = cells[25].Value.ToString();
            Program.products.depth = cells[26].Value.ToString();
            Program.products.weight = cells[27].Value.ToString();
            Program.products.moust_type = cells[28].Value.ToString();
            Program.products.power = cells[29].Value.ToString();
            Program.products.webcam = cells[30].Value.ToString();
            //string outputString = string.Empty;
            //for (int i = 0; i < columnCount; i++)
            //{
            //    outputString += cells[i].Value.ToString() + " ";
            //}

            //SelectionDataLabel.Text = outputString;
            SelectionDataLabel.Text = cells[1].Value.ToString() + cells[3].Value.ToString() + cells[2].Value.ToString();
        }
    }
}
