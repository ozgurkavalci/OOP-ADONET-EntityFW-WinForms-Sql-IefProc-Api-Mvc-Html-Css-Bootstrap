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
using System.Xml.Linq;

namespace _05052022_Ucuncu_uygulama_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        void Yukle()
        {
            XmlDocument i=new XmlDocument();    //varolan bir dosya ile çalışacaksam nesne böyle uretilir

            //<personel id>="10"> attribute deniliyor

            DataSet ds=new DataSet();

            //xml dosyaımızı okumak ıcın bir reader olustuyoruz.

            XmlReader XmlFile;

            XmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings()); // içeriği datasete aktarıyoruz

            ds.ReadXml(XmlFile);

            dataGridView1.DataSource=ds.Tables[0];  
            XmlFile.Close();    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yukle();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            x.Element("personeller").Add(new XElement("personel", new XElement("id", textBox1.Text),

            new XElement("adi", textBox2.Text),
            new XElement("soyadi", textBox3.Text),
            new XElement("telefonu", textBox4.Text)));
            x.Save(@"veri.xml");
            Yukle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");

            x.Root.Elements().Where(a => a.Element("id").Value == textBox1.Text).Remove();
            x.Save(@"veri.xml");
            Yukle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node = x.Element("personeller").Elements("personel").FirstOrDefault(a => a.Element("id").Value.Trim() == textBox1.Text);
            //trim boşluk hassasiyetini ortadan kaldırır. ilk bulduğu boşta çalışır.
            if (node != null)
            {
                node.SetElementValue("adi", textBox2.Text);
                node.SetElementValue("soyadi", textBox3.Text);
                node.SetElementValue("telefonu", textBox4.Text);
                x.Save(@"veri.xml");
                Yukle();
            }
        }
    }
}
