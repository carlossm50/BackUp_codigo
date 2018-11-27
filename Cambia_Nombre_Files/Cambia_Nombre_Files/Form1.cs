using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CRPEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Text = "";
            foreach (string foundFile in System.IO.Directory.GetFiles(@"C:\CAM\Ambientes\CCR\Bas\Analitco cta\Analiticos validados\201402", "*.ENV"))
            {
                listBox1.Items.Add(foundFile);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Object o  in listBox1.Items)
            {
                String str  = o.ToString();
                String str1 ="";

                str1 = str.Replace(@"C:\CAM\Ambientes\CCR\Bas\Analitco cta\Analiticos validados\201402\", "");
                str1 = str.Replace(".ENV", ".txt");

                //listBox2.Items.Add(str1.Replace(".ENV", ".TXT") + "");
                if (System.IO.File.Exists(str))
                { System.IO.File.Move(str, str1); }
                else
                    { MessageBox.Show("Nose se encontro el archivo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }
    }
}
