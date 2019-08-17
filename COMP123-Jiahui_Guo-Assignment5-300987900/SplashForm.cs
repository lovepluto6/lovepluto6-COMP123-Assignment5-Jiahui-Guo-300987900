using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Jiahui_Guo_Assignment5_300987900
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreentimer_Tick(object sender, EventArgs e)
        {
            SplashScreentimer.Enabled = false;
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashScreentimer.Enabled = true;
        }
    }
}
