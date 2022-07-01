using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomPassword
{
    public partial class Form1 : Form
    {
        string Password;
        public Form1()
        {
            InitializeComponent();
        }

        private void Randombtn_Click(object sender, EventArgs e)
        {
            int length;
            Random random = new Random();
            String dataset = "abcdefghijklmnopqrstuvwxyz0123456789";
            length = 3;
            Password = "";
            for (int i = 0; i < length; i++)
            {
                int datasetpositon = random.Next(dataset.Length);
                Password = Password + dataset.ElementAt(datasetpositon);                
            }
            label1.Text = Password;
        }
    }


}
