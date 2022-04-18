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


namespace WindowsFormODEVXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void btn_giris_Click(object sender, EventArgs e)
        {
            string xmlpath = Application.StartupPath + "\\Customer.xml";
            XmlTextWriter customer = new XmlTextWriter(xmlpath, UTF8Encoding.UTF8);
            customer.Formatting = Formatting.Indented;
            customer.WriteStartDocument();
            customer.WriteStartElement("öĞRENCİLER");
            customer.WriteStartElement("öĞRENCİ");

            customer.WriteStartAttribute("ID", "1");
            customer.WriteElementString("Öğrenci ", txt_isim.Text);
            customer.WriteElementString("Öğrenci Soyisim", txt_Sisim.Text);

            customer.WriteEndElement();
            customer.WriteEndElement();
            customer.Close();
            MessageBox.Show("KAYIT GERÇEKLEŞTİ");
            Application.Exit();
        }
    }
}
