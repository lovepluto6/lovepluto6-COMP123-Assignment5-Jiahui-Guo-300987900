using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Jiahui_Guo_Assignment5_300987900
{
    public partial class ProductInfoForm : Form
    {
        public ProductInfoForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            orderForm.Show();
            this.Hide();
        }

        private void SelectFormCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProductInfoForm_Load(object sender, EventArgs e)
        {
            ProductIDDataLabel.Text = Convert.ToString(Program.products.productID);
            CostDataLabel.Text = Convert.ToString(Program.products.cost);
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
            OSDataLabel.Text = Program.products.OS ;
            PlatformDataLabel.Text = Program.products.platform ;
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

        private void SelectanotherButton_Click(object sender, EventArgs e)
        {
            SelectForm selectForm = new SelectForm();
            selectForm.Show();
            this.Hide();
        }

        private void SavetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter outputString = new StreamWriter(File.Open("Product.txt", FileMode.Create));

            //all products
            outputString.WriteLine(Program.products.productID);


            outputString.WriteLine(Convert.ToString(Program.products.productID));
            outputString.WriteLine(Convert.ToString(Program.products.cost));
            outputString.WriteLine(Program.products.manufacturer);
            outputString.WriteLine(Program.products.model);
            outputString.WriteLine(Program.products.RAM_size);
            outputString.WriteLine(Program.products.displaytype);
            outputString.WriteLine(Program.products.CPU_brand);
            outputString.WriteLine(Program.products.CPU_type);
            outputString.WriteLine(Program.products.CPU_speed);
            outputString.WriteLine(Program.products.CPU_number);
            outputString.WriteLine(Program.products.condition);
            outputString.WriteLine(Program.products.OS);
            outputString.WriteLine(Program.products.platform);
            outputString.WriteLine(Program.products.HDD_size);
            outputString.WriteLine(Program.products.GPU_Type);
            outputString.WriteLine(Program.products.webcam);

            //cleanup
            outputString.Close();
            outputString.Dispose();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open txt
            using (StreamReader inputStream =new StreamReader(
                File.Open("Product.txt", FileMode.Open)))
            {
                //read all
                Program.products.productID = short.Parse(inputStream.ReadLine());
                Program.products.cost = decimal.Parse(inputStream.ReadLine());
                Program.products.manufacturer = inputStream.ReadLine();
                Program.products.model = inputStream.ReadLine();
                Program.products.RAM_size = inputStream.ReadLine();
                Program.products.displaytype = inputStream.ReadLine();
                Program.products.CPU_brand = inputStream.ReadLine();
                Program.products.CPU_type = inputStream.ReadLine();
                Program.products.CPU_speed = inputStream.ReadLine();
                Program.products.CPU_number = inputStream.ReadLine();
                Program.products.condition = inputStream.ReadLine();
                Program.products.OS = inputStream.ReadLine();
                Program.products.platform = inputStream.ReadLine();
                Program.products.HDD_size = inputStream.ReadLine();
                Program.products.GPU_Type = inputStream.ReadLine();
                Program.products.webcam = inputStream.ReadLine();

                //clean up
                inputStream.Close();
                inputStream.Dispose();

                //label=to content
                ProductIDDataLabel.Text = Convert.ToString(Program.products.productID);
                CostDataLabel.Text = Convert.ToString(Program.products.cost);
                ManufacturerDataLabel.Text = Program.products.manufacturer;
                ModelDataLabel.Text = Program.products.model;
                MemoryDataLabel.Text = Program.products.RAM_size;
                LCDsizeDataLabel.Text = Program.products.displaytype;
                CPUBrandDataLabel.Text = Program.products.CPU_brand;
                CPUTypeDataLabel.Text = Program.products.CPU_type;
                CPUSpeedDataLabel.Text = Program.products.CPU_speed;
                CPUnumberDataLabel.Text = Program.products.CPU_number;
                ConditionDataLabel.Text = Program.products.condition;
                OSDataLabel.Text = Program.products.OS;
                PlatformDataLabel.Text = Program.products.platform;
                HDDDataLabel.Text = Program.products.HDD_size;
                GPUTypeDataLabel.Text = Program.products.GPU_Type;
                WebcamDataLabel.Text = Program.products.webcam;
            }
        }
    }
}
