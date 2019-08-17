using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Jiahui_Guo_Assignment5_300987900
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProductPrintForm.PrintAction = PrintAction.PrintToPreview;
            ProductPrintForm.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.aboutForm.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ProductInfoForm productInfoForm = new ProductInfoForm();
            productInfoForm.Show();
            this.Hide();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //ProductIDDataLabel.Text = Convert.ToString(Program.products.productID);
            PriceDataLabel.Text = Convert.ToString(Program.products.cost);
            SalesTaxDataLabel.Text = Convert.ToString(Convert.ToDouble(Program.products.cost )*.13);
            TotalDataLabel.Text = Convert.ToString(Convert.ToDouble(Program.products.cost) * 1.13);

            ManufacturerDataLabel.Text = Program.products.manufacturer;
            ModelDataLabel.Text = Program.products.model;
            //ManufacturerDataLabel.Text = Program.products.RAM_type;
            MemoryDataLabel.Text = Program.products.RAM_size;
            LCDsizeDataLabel.Text = Program.products.displaytype;
            //ManufacturerDataLabel.Text = Program.products.screensize;
            //ManufacturerDataLabel.Text = Program.products.resolution;
            //ManufacturerDataLabel.Text = Program.products.CPU_Class;
            CPUBrandDataLabel.Text = Program.products.CPU_brand;
            CPUTypeDataLabel.Text = Program.products.CPU_type;
            CPUSpeedDataLabel.Text = Program.products.CPU_speed;
            CPUnumberDataLabel.Text = Program.products.CPU_number;
            ConditionDataLabel.Text = Program.products.condition;
            OSDataLabel.Text = Program.products.OS;
            PlatformDataLabel.Text = Program.products.platform;
            HDDDataLabel.Text = Program.products.HDD_size;
            //ManufacturerDataLabel.Text = Program.products.HDD_speed;
            GPUTypeDataLabel.Text = Program.products.GPU_Type;
            //ManufacturerDataLabel.Text = Program.products.optical_drive;
            //ManufacturerDataLabel.Text = Program.products.Audio_type;
            //ManufacturerDataLabel.Text = Program.products.LAN ;
            //ManufacturerDataLabel.Text = Program.products.WIFI;
            //ManufacturerDataLabel.Text = Program.products.width;
            //ManufacturerDataLabel.Text = Program.products.height;
            //ManufacturerDataLabel.Text = Program.products.depth ;
            //ManufacturerDataLabel.Text = Program.products.weight;
            // ManufacturerDataLabel.Text = Program.products.moust_type;
            // ManufacturerDataLabel.Text = Program.products.power ;
            WebcamDataLabel.Text = Program.products.webcam;
        }
        //message to the user that thanks him for his business and advises him that his order will be
        //processed in 7 - 10 business days.Ensure this information is double spaced and displayed over at
        //least two lines.
        private void FinishButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Thanks you for your business. .\n\r Your order will be processed in 7 - 10 business days.", "Thank you!", MessageBoxButtons.OK)==DialogResult.OK)
            { Application.Exit(); }



        }
    }
}
