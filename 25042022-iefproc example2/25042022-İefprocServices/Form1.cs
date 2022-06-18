using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25042022_İefprocServices
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ServicesEntities servis= new ServicesEntities();

        private void button2_Click(object sender, EventArgs e)
        {
            Hizmet hizmet1=new Hizmet();
            hizmet1.Show();
            this.Hide();
        }
    }
}
