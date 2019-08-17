using COMP123_Jiahui_Guo_Assignment5_300987900.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_Jiahui_Guo_Assignment5_300987900
{
    

   public static class Program
    {
        public static StartForm startForm;
        public static SplashForm splashForm;
        public static ProductInfoForm productInfoForm;
        public static OrderForm orderForm;
        public static SelectForm selectForm;
        public static AboutForm aboutForm;

        public static products products;
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            startForm = new StartForm();
            splashForm = new SplashForm();
            productInfoForm = new ProductInfoForm();
            orderForm = new OrderForm();
            selectForm = new SelectForm();
            aboutForm = new AboutForm();

            products = new products();

            //Application.Run(splashForm);
            Application.Run(splashForm);
        }
    }
}
