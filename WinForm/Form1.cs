using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
namespace WinForm
{
    public partial class Form1 : Form
    {
        static FabiWebService.WebServiceSoapClient FabWs = new FabiWebService.WebServiceSoapClient();
       


        Form progForm = new Form
        {
            Width = 600,
            Height = 400,
            MaximizeBox = false,
            MinimizeBox = false,
            FormBorderStyle = FormBorderStyle.None,
            Text = "BusyForm",
            StartPosition=FormStartPosition.CenterScreen,
            BackColor=Color.DodgerBlue
        };

        public Form1()
        {
            InitializeComponent();
        }
        public int CallFbinacci()
        {
            System.Threading.Thread.Sleep(2000); 
            return FabWs.Fibonacci(10);
        }
        private void Button1_Click(object sender, EventArgs e)
        {

            var task1 = Task.Run(new Action(() =>
            {
                int x = CallFbinacci();
                MessageBox.Show(x.ToString());

                progForm.Invoke(new MethodInvoker(delegate ()
                            {
                                progForm.Close();
                            }

                    ));

            }
                ));

            progForm.ShowDialog();


        }

       
    }
}
