using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2EMLAKörneği
{
    public partial class SonucEkranı : Form
    {
        public SonucEkranı()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           Apartmanbil gönder=new Apartmanbil();    
            
        }

        private void SonucEkranı_Load(object sender, EventArgs e)
        {

        }
    }
}
