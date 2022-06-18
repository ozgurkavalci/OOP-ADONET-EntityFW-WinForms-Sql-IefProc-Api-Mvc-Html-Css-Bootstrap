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

namespace _5052022_xml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //XmlDocument i=new XmlDocument();
            //DataSet ds=new DataSet();

            ////xml dosyamızı okumak ıcın bir reader olusturuyoruz

            //XmlReader XmlFile;

            ////Reader in içine path ini verdiğimiz dosyayı dolduruyoruz. Burada önemli olan bir nokta var. Path imizin
            ////başına @ yazacağız ve çift tırnak kullanacağız.


            //XmlFile = XmlReader.Create(@"pveri.xml", new XmlReaderSettings());

            //// içeriği dataset e aktarıyoruz.

            //ds.ReadXml(XmlFile);

            ////gridview ın kaynağı olarak dateset i gösteriyoruz.

            //dataGridView1.DataSource=ds.Tables[0];
            //XmlFile.Close();



            XmlDocument i = new XmlDocument();
            DataSet ds = new DataSet();

            //xml dosyamızı okumak için bir reader oluşturuyoruz.  

            XmlReader XmlFile;

            //readerin içine pathini veridiğimiz dosyayı dolduruyoruz. Burada önemli olan bir nokta var ya path imizin başına @ yazacağız çift tırnak kullanacağız.
            XmlFile = XmlReader.Create(@"pverii.xml", new XmlReaderSettings());
            //içeriği datasete aktarıyoruz.
            ds.ReadXml(XmlFile);
            //gridview in kaynağı olarak dateseti gösteriyoruz.
            dataGridView1.DataSource = ds.Tables[0];
            XmlFile.Close();





        }
    }
}
