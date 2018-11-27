using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.Common;
using System.Data.SqlClient;

namespace COMPARSIB
{
    public partial class Form1 : Form
    {
        //Variables locales
        public SqlConnection Coneccion = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
        }

        private void Cargar_DB(object sender, EventArgs e)
        {
            frmLoging login = new frmLoging(Coneccion);
            login.StartPosition = FormStartPosition.CenterScreen;
            //FrmTecnicoDocente login = new FrmTecnicoDocente();     //login.MdiParent = this;
            login.ShowDialog(this);
            Coneccion = login.cnt;
            mantenimiento joder = new mantenimiento(login.serverSQL, login.usuario, login.clave, cbBaseDatos);
            //Coneccion.Open();
            //Coneccion.Close();
            //MessageBox.Show("Exito");

        }
        private void Cargar_archivo_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            DECNT _decnt  = new DECNT();
            DEPROV _depro = new DEPROV();
            mantenimiento mant = new mantenimiento();
            string ruta = string.Empty;
            if (OdgArchivos.ShowDialog() == DialogResult.OK)
            {
                ruta = OdgArchivos.FileName;
                //MessageBox.Show(ruta);

            }
            else
            {
                return;
            }

            try
            {
                System.IO.StreamReader file = new System.IO.StreamReader(ruta);
                //new System.IO.StreamReader(@"C:\CAM\DE25.txt");
                richTextBox1.Clear();
                if (cbArchivos.Text == "DE21")
                {
                    if (mant.BorraDE(21, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }

                if (cbArchivos.Text == "DE23")
                {
                    if (mant.BorraDE(23, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }

                if (cbArchivos.Text == "DE25")
                {
                    if (mant.BorraDE(25, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                if (cbArchivos.Text == "DE11")
                {
                    if (mant.BorraDE(11, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                if (cbArchivos.Text == "DE13")
                {
                    if (mant.BorraDE(13, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                if (cbArchivos.Text == "DE15")
                {
                    if (mant.BorraDE(15, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                while ((line = file.ReadLine()) != null)
                {
                    if (cbArchivos.Text == "DE21" || cbArchivos.Text == "DE23" || cbArchivos.Text == "DE25")
                    {
                        System.Console.WriteLine(line);
                        richTextBox1.Text += line.Substring(0, 7) +
                                             line.Substring(7, 27) +
                                             line.Substring(34, 35) +
                                             line.Substring(69, 15) +
                                             line.Substring(84, 4) +
                                             line.Substring(88, 3);
                        counter++;
                        if (cbArchivos.Text == "DE21")
                        {
                            llenarDECNT(_decnt, line);
                            richTextBox1.Text += line.Substring(91, 1);
                            _decnt.Tipo_moneda = System.Convert.ToChar(line.Substring(91, 1));
                            //MessageBox.Show("DE21");
                            if (mant.GuardaDE21(_decnt, Coneccion) != true)
                            {

                                MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _decnt.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                return;
                            }
                        }
                        if (cbArchivos.Text == "DE25")
                        {
                            llenarDECNT(_decnt, line);
                            //MessageBox.Show("DE25");
                            if (mant.GuardaDE25(_decnt, Coneccion) != true)
                            {

                                MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _decnt.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                return;
                            }
                        }
                        if (cbArchivos.Text == "DE23")
                        {
                            //MessageBox.Show("DE23");
                            llenarDECNT(_decnt, line);
                            if (mant.GuardaDE23(_decnt, Coneccion) != true)
                            {

                                MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _decnt.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                return;
                            }
                        }
                        richTextBox1.Text += '\n';
                    }
                    else 
                    {
                        if (cbArchivos.Text == "DE11" || cbArchivos.Text == "DE13" || cbArchivos.Text == "DE15")
                        {
                            System.Console.WriteLine(line);
                            if (cbArchivos.Text == "DE11")
                            {
                                richTextBox1.Text += line.Substring(0, 7) +
                                                     line.Substring(7, 15) +
                                                     line.Substring(22, 2) +
                                                     line.Substring(24, 60) +
                                                     line.Substring(84, 30) +
                                                     line.Substring(114, 27) +
                                                     line.Substring(141, 27) +
                                                     line.Substring(168, 10) +
                                                     line.Substring(178, 15) +
                                                     line.Substring(193, 10) +
                                                     line.Substring(203, 15) +
                                                     line.Substring(218, 10) +
                                                     line.Substring(228, 10) +
                                                     line.Substring(238, 15) +
                                                     line.Substring(253, 1) +
                                                     line.Substring(254, 1) +
                                                     line.Substring(255, 2) +
                                                     line.Substring(257, 6) +
                                                     line.Substring(263, 1) +
                                                     line.Substring(264, 1) +
                                                     line.Substring(265, 1) +
                                                     line.Substring(266, 1) +
                                                     line.Substring(267, 1) +
                                                     line.Substring(268, 15) +
                                                     line.Substring(283, 2) +
                                                     line.Substring(285, 2) +
                                                     line.Substring(287, 15) +
                                                     line.Substring(302, 10) +
                                                     line.Substring(312, 10) +
                                                     line.Substring(322, 6) +
                                                     line.Substring(328, 6) +
                                                     line.Substring(334, 6) +
                                                     line.Substring(340, 5) +
                                                     line.Substring(345, 1) +
                                                     line.Substring(346, 2) +
                                                     line.Substring(348, 10) +
                                                     line.Substring(358, 15) +
                                                     line.Substring(373, 60) +
                                                     line.Substring(433, 2) +
                                                     line.Substring(435, 6) +
                                                     line.Substring(441, 15) +
                                                     line.Substring(456, 15) +
                                                     line.Substring(471, 15) +
                                                     line.Substring(486, 10) +
                                                     line.Substring(496, 10) +
                                                     line.Substring(506, 15) +
                                                     line.Substring(521, 3) +
                                                     line.Substring(524, 3) +
                                                     line.Substring(527, 3) +
                                                     line.Substring(530, 3) +
                                                     line.Substring(533, 1);
                            }
                            else
                            {
                                if (cbArchivos.Text == "DE13")
                                {
                                    richTextBox1.Text += line.Substring(0, 7) +
                                                         line.Substring(7, 15) +
                                                         line.Substring(22, 2) +
                                                         line.Substring(24, 60) +
                                                         line.Substring(84, 30) +
                                                         line.Substring(114, 27) +
                                                         line.Substring(141, 10) +
                                                         line.Substring(151, 15) +
                                                         line.Substring(166, 10) +
                                                         line.Substring(176, 10) +
                                                         line.Substring(186, 10) +
                                                         line.Substring(196, 6) +
                                                         line.Substring(202, 1) +
                                                         line.Substring(203, 1) +
                                                         line.Substring(204, 2) +
                                                         line.Substring(206, 15) +
                                                         line.Substring(221, 2) +
                                                         line.Substring(223, 6) +
                                                         line.Substring(229, 5) +
                                                         line.Substring(234, 1) +
                                                         line.Substring(235, 1) +
                                                         line.Substring(236, 10) +
                                                         line.Substring(246, 10) +
                                                         line.Substring(256, 10) +//bien
                                                         line.Substring(266, 15) +
                                                         line.Substring(281, 2) +
                                                         line.Substring(283, 6) +
                                                         line.Substring(289, 15) +
                                                         line.Substring(304, 15) +
                                                         line.Substring(319, 15) +
                                                         line.Substring(334, 10) +
                                                         line.Substring(344, 10) +
                                                         line.Substring(354, 15) +
                                                         line.Substring(369, 2) +
                                                         line.Substring(371, 3) +
                                                         line.Substring(374, 3);
                                }
                                else 
                                {
                                    if (cbArchivos.Text == "DE15")
                                    {
                                        richTextBox1.Text += line.Substring(0, 7) +
                                                             line.Substring(7, 15) +
                                                             line.Substring(22, 2) +
                                                             line.Substring(24, 60) +
                                                             line.Substring(84, 30) +
                                                             line.Substring(114, 27) +
                                                             line.Substring(141, 10) +
                                                             line.Substring(151, 15) +
                                                             line.Substring(166, 10) +
                                                             line.Substring(176, 10) +
                                                             line.Substring(186, 10) +
                                                             line.Substring(196, 6) +
                                                             line.Substring(202, 1) +
                                                             line.Substring(203, 1) +
                                                             line.Substring(204, 2) +
                                                             line.Substring(206, 15) +
                                                             line.Substring(221, 2) +
                                                             line.Substring(223, 6) +
                                                             line.Substring(229, 5) +//bien
                                                             line.Substring(234, 10) +
                                                             line.Substring(244, 10) +
                                                             line.Substring(254, 2) +
                                                             line.Substring(256, 6) +
                                                             line.Substring(262, 15) +
                                                             line.Substring(277, 15) +
                                                             line.Substring(292, 10) +
                                                             line.Substring(302, 10) +
                                                             line.Substring(312, 15) +
                                                             line.Substring(327, 2) +
                                                             line.Substring(329, 3) +
                                                             line.Substring(332, 3) ;
                                    }
                                }
                            }

                                                
                        counter++;
                        if (cbArchivos.Text == "DE11")
                        {
                            llenarDE11(_depro, line);
                            if (mant.GuardaDE11(_depro, Coneccion) != true)
                            {

                                MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _depro.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                return;
                            }

                        }
                        else 
                        {
                            if (cbArchivos.Text == "DE13")
                            {
                                llenarDE13(_depro, line);
                                if (mant.GuardaDE13(_depro, Coneccion) != true)
                                {

                                    MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _depro.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                    return;
                                }

                            }
                            else
                            {
                                if (cbArchivos.Text == "DE15")
                                {
                                    llenarDE15(_depro, line);
                                    if (mant.GuardaDE15(_depro, Coneccion) != true)
                                    {

                                        MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _depro.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                        return;
                                    }

                                }
                            
                            }
 
                        }
                        
                          //  return; //*****************************

                        }
                        richTextBox1.Text += '\n';
                    }
                }

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }
        }
        private void Cargar_archivoCli_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            DECNT _decnt = new DECNT();
            DEPROV _depro = new DEPROV();
            mantenimiento mant = new mantenimiento();
            string ruta = string.Empty;
            if (OdgArchivos.ShowDialog() == DialogResult.OK)
            {
                ruta = OdgArchivos.FileName;
                //MessageBox.Show(ruta);

            }
            else
            {
                return;
            }

            try
            {
                System.IO.StreamReader file =
                    new System.IO.StreamReader(ruta);
                //new System.IO.StreamReader(@"C:\CAM\DE25.txt");
                richTextBox2.Clear();
                if (cbArchivos.Text == "DE21")
                {
                    if (mant.BorraDE(26, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }

                if (cbArchivos.Text == "DE23")
                {
                    if (mant.BorraDE(27, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }

                if (cbArchivos.Text == "DE25")
                {
                    if (mant.BorraDE(28, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                if (cbArchivos.Text == "DE11")
                {
                    if (mant.BorraDE(16, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                if (cbArchivos.Text == "DE13")
                {
                    if (mant.BorraDE(17, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                if (cbArchivos.Text == "DE15")
                {
                    if (mant.BorraDE(18, Coneccion) != true)
                    {

                        MessageBox.Show("Ha ocurrido un error borrando registros");
                        return;
                    }
                }
                while ((line = file.ReadLine()) != null)
                {
                    if (cbArchivos.Text == "DE21" || cbArchivos.Text == "DE23" || cbArchivos.Text == "DE25")
                    {
                        System.Console.WriteLine(line);
                        richTextBox2.Text += line.Substring(0, 7) +
                                             line.Substring(7, 27) +
                                             line.Substring(34, 35) +
                                             line.Substring(69, 15) +
                                             line.Substring(84, 4) +
                                             line.Substring(88, 3);
                        counter++;
                        if (cbArchivos.Text == "DE21")
                        {
                            llenarDECNT(_decnt, line);
                            richTextBox2.Text += line.Substring(91, 1);
                            _decnt.Tipo_moneda = System.Convert.ToChar(line.Substring(91, 1));
                            //MessageBox.Show("DE21");
                            if (mant.GuardaDE21CLI(_decnt, Coneccion) != true)
                            {

                                MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _decnt.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                return;
                            }
                        }
                        if (cbArchivos.Text == "DE25")
                        {
                            llenarDECNT(_decnt, line);
                            //MessageBox.Show("DE25");
                            if (mant.GuardaDE25CLI(_decnt, Coneccion) != true)
                            {

                                MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _decnt.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                return;
                            }
                        }
                        if (cbArchivos.Text == "DE23")
                        {
                            //MessageBox.Show("DE23");
                            llenarDECNT(_decnt, line);
                            if (mant.GuardaDE23CLI(_decnt, Coneccion) != true)
                            {

                                MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _decnt.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                return;
                            }
                        }
                        richTextBox2.Text += '\n';
                    }
                    else
                    {
                        if (cbArchivos.Text == "DE11" || cbArchivos.Text == "DE13" || cbArchivos.Text == "DE15")
                        {
                            System.Console.WriteLine(line);
                            if (cbArchivos.Text == "DE11")
                            {
                                richTextBox2.Text += line.Substring(0, 7) +
                                                     line.Substring(7, 15) +
                                                     line.Substring(22, 2) +
                                                     line.Substring(24, 60) +
                                                     line.Substring(84, 30) +
                                                     line.Substring(114, 27) +
                                                     line.Substring(141, 27) +
                                                     line.Substring(168, 10) +
                                                     line.Substring(178, 15) +
                                                     line.Substring(193, 10) +
                                                     line.Substring(203, 15) +
                                                     line.Substring(218, 10) +
                                                     line.Substring(228, 10) +
                                                     line.Substring(238, 15) +
                                                     line.Substring(253, 1) +
                                                     line.Substring(254, 1) +
                                                     line.Substring(255, 2) +
                                                     line.Substring(257, 6) +
                                                     line.Substring(263, 1) +
                                                     line.Substring(264, 1) +
                                                     line.Substring(265, 1) +
                                                     line.Substring(266, 1) +
                                                     line.Substring(267, 1) +
                                                     line.Substring(268, 15) +
                                                     line.Substring(283, 2) +
                                                     line.Substring(285, 2) +
                                                     line.Substring(287, 15) +
                                                     line.Substring(302, 10) +
                                                     line.Substring(312, 10) +
                                                     line.Substring(322, 6) +
                                                     line.Substring(328, 6) +
                                                     line.Substring(334, 6) +
                                                     line.Substring(340, 5) +
                                                     line.Substring(345, 1) +
                                                     line.Substring(346, 2) +
                                                     line.Substring(348, 10) +
                                                     line.Substring(358, 15) +
                                                     line.Substring(373, 60) +
                                                     line.Substring(433, 2) +
                                                     line.Substring(435, 6) +
                                                     line.Substring(441, 15) +
                                                     line.Substring(456, 15) +
                                                     line.Substring(471, 15) +
                                                     line.Substring(486, 10) +
                                                     line.Substring(496, 10) +
                                                     line.Substring(506, 15) +
                                                     line.Substring(521, 3) +
                                                     line.Substring(524, 3) +
                                                     line.Substring(527, 3) +
                                                     line.Substring(530, 3) +
                                                     line.Substring(533, 1);
                            }
                            else
                            {
                                if (cbArchivos.Text == "DE13")
                                {
                                    richTextBox2.Text += line.Substring(0, 7) +
                                                         line.Substring(7, 15) +
                                                         line.Substring(22, 2) +
                                                         line.Substring(24, 60) +
                                                         line.Substring(84, 30) +
                                                         line.Substring(114, 27) +
                                                         line.Substring(141, 10) +
                                                         line.Substring(151, 15) +
                                                         line.Substring(166, 10) +
                                                         line.Substring(176, 10) +
                                                         line.Substring(186, 10) +
                                                         line.Substring(196, 6) +
                                                         line.Substring(202, 1) +
                                                         line.Substring(203, 1) +
                                                         line.Substring(204, 2) +
                                                         line.Substring(206, 15) +
                                                         line.Substring(221, 2) +
                                                         line.Substring(223, 6) +
                                                         line.Substring(229, 5) +
                                                         line.Substring(234, 1) +
                                                         line.Substring(235, 1) +
                                                         line.Substring(236, 10) +
                                                         line.Substring(246, 10) +
                                                         line.Substring(256, 10) +//bien
                                                         line.Substring(266, 15) +
                                                         line.Substring(281, 2) +
                                                         line.Substring(283, 6) +
                                                         line.Substring(289, 15) +
                                                         line.Substring(304, 15) +
                                                         line.Substring(319, 15) +
                                                         line.Substring(334, 10) +
                                                         line.Substring(344, 10) +
                                                         line.Substring(354, 15) +
                                                         line.Substring(369, 2) +
                                                         line.Substring(371, 3) +
                                                         line.Substring(374, 3);
                                }
                                else
                                {
                                    if (cbArchivos.Text == "DE15")
                                    {
                                        richTextBox2.Text += line.Substring(0, 7) +
                                                             line.Substring(7, 15) +
                                                             line.Substring(22, 2) +
                                                             line.Substring(24, 60) +
                                                             line.Substring(84, 30) +
                                                             line.Substring(114, 27) +
                                                             line.Substring(141, 10) +
                                                             line.Substring(151, 15) +
                                                             line.Substring(166, 10) +
                                                             line.Substring(176, 10) +
                                                             line.Substring(186, 10) +
                                                             line.Substring(196, 6) +
                                                             line.Substring(202, 1) +
                                                             line.Substring(203, 1) +
                                                             line.Substring(204, 2) +
                                                             line.Substring(206, 15) +
                                                             line.Substring(221, 2) +
                                                             line.Substring(223, 6) +
                                                             line.Substring(229, 5) +//bien
                                                             line.Substring(234, 10) +
                                                             line.Substring(244, 10) +
                                                             line.Substring(254, 2) +
                                                             line.Substring(256, 6) +
                                                             line.Substring(262, 15) +
                                                             line.Substring(277, 15) +
                                                             line.Substring(292, 10) +
                                                             line.Substring(302, 10) +
                                                             line.Substring(312, 15) +
                                                             line.Substring(327, 2) +
                                                             line.Substring(329, 3) +
                                                             line.Substring(332, 3);
                                    }
                                }
                            }


                            counter++;
                            if (cbArchivos.Text == "DE11")
                            {
                                llenarDE11(_depro, line);
                                if (mant.GuardaDE11CLI(_depro, Coneccion) != true)
                                {

                                    MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _depro.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                    return;
                                }

                            }
                            else
                            {
                                if (cbArchivos.Text == "DE13")
                                {
                                    llenarDE13(_depro, line);
                                    if (mant.GuardaDE13CLI(_depro, Coneccion) != true)
                                    {

                                        MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _depro.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                        return;
                                    }

                                }
                                else
                                {
                                    if (cbArchivos.Text == "DE15")
                                    {
                                        llenarDE15(_depro, line);
                                        if (mant.GuardaDE15CLI(_depro, Coneccion) != true)
                                        {

                                            MessageBox.Show("Ha ocurrido un error en la cuenta No. " + _depro.Codigo_Credito + "\\n" + Coneccion.ConnectionString);
                                            return;
                                        }

                                    }

                                }

                            }

                            //  return; //*****************************

                        }
                    }
                }

                file.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void btnCombinarCta_Click(object sender, EventArgs e)
        {
            //select * 
            //--update b set b.referencia=c.cuecta_refer
              //from DE21banke b inner join Easybank_bct20..ecuectam c on b.cod_cred=c.cuecta_formateado
            mantenimiento mant = new mantenimiento();
            string qry = "update ";
            try
            {
                if (cbArchivos.Text == string.Empty) 
                { 
                    MessageBox.Show("Debe especificar el tipo de archivo.");
                    return; 
                }

                if (cbBaseDatos.Text.Trim() != string.Empty)
                {
                    if (cbArchivos.Text == "DE21")
                    {
                        qry += "DE21Banke set referencia = " + cbBaseDatos.Text + "..ecuectam.cuecta_refer from DE21banke  inner join " + cbBaseDatos.Text + "..ecuectam on DE21banke.cod_cred = " + cbBaseDatos.Text + "..ecuectam.cuecta_formateado ";
                        mant.Combinar(qry, Coneccion);
                    }
                    else 
                    {
                        if (cbArchivos.Text == "DE23")
                        {
                            qry += "DE23Banke set referencia = " + cbBaseDatos.Text + "..ecuectam.cuecta_refer from DE23Banke  inner join " + cbBaseDatos.Text + "..ecuectam on DE23Banke.cod_cred = " + cbBaseDatos.Text + "..ecuectam.cuecta_formateado ";
                            mant.Combinar(qry, Coneccion);
                        }
                        else
                        {
                            if (cbArchivos.Text == "DE25")
                            {
                                qry += "DE25Banke set referencia = " + cbBaseDatos.Text + "..ecuectam.cuecta_refer from DE25Banke  inner join " + cbBaseDatos.Text + "..ecuectam on DE25Banke.cod_cred = " + cbBaseDatos.Text + "..ecuectam.cuecta_formateado ";
                                mant.Combinar(qry, Coneccion);
                            }
                            else 
                            {
                                if (cbArchivos.Text == "DE11")
                                {
                                    qry += "DE11Banke set referencia = " + cbBaseDatos.Text + "..ecuectam.cuecta_refer from DE11Banke  inner join " + cbBaseDatos.Text + "..ecuectam on DE11Banke.codigo_Credito = " + cbBaseDatos.Text + "..ecuectam.cuecta_formateado ";
                                    mant.Combinar(qry, Coneccion);
                                }
                                else
                                {
                                    if (cbArchivos.Text == "DE13")
                                    {
                                        qry += "DE13Banke set referencia = " + cbBaseDatos.Text + "..ecuectam.cuecta_refer from DE13Banke  inner join " + cbBaseDatos.Text + "..ecuectam on DE13Banke.codigo_Credito = " + cbBaseDatos.Text + "..ecuectam.cuecta_formateado ";
                                        mant.Combinar(qry, Coneccion);
                                    }
                                    else
                                    {
                                        if (cbArchivos.Text == "DE15")
                                        {
                                            qry += "DE15Banke set referencia = " + cbBaseDatos.Text + "..ecuectam.cuecta_refer from DE15Banke  inner join " + cbBaseDatos.Text + "..ecuectam on DE15Banke.codigo_Credito = " + cbBaseDatos.Text + "..ecuectam.cuecta_formateado ";
                                            mant.Combinar(qry, Coneccion);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Tipo de archivo invalido.");
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                else 
                {
                    MessageBox.Show("Debe especificar la Base de datos de donde se tomará la referencia.");
                    return; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private static void llenarDECNT(  DECNT _decnt,string line) 
        {
            _decnt.Numero_secuencial = System.Convert.ToInt32(line.Substring(0, 7));
            _decnt.Codigo_Credito = line.Substring(7, 27);
            _decnt.Cuenta_contable = line.Substring(34, 35);
            _decnt.Monto_pendiente = System.Convert.ToDecimal(line.Substring(69, 15));
            _decnt.Dias_atraso = System.Convert.ToInt32(line.Substring(84, 4));
            _decnt.Numero_cuotas = System.Convert.ToInt32(line.Substring(88, 3));
                    
        }
        private static void llenarDE11(DEPROV _deprov, string line)
        {
            switch (line.Substring(0, 7).Trim())
            {
                case "": _deprov.Numero_secuencial = 0;
                    break;
                default: _deprov.Numero_secuencial = System.Convert.ToInt32(line.Substring(0, 7));
                    break;
            }
            
            _deprov.Identificacion = line.Substring(7, 15);
            _deprov.Tipo_persona = line.Substring(22, 2);
            _deprov.Nombre = line.Substring(24, 60);
            _deprov.Apellido = line.Substring(84, 30);
            _deprov.Codigo_Credito = line.Substring(114, 27);
            _deprov.Codigo_facilidad = line.Substring(141, 27);

            switch (line.Substring(168, 10).Trim())
            {
                case "": _deprov.Fecha_aprobacion = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_aprobacion = System.Convert.ToDateTime(line.Substring(168, 10)); break;
            }

            switch (line.Substring(178, 15).Trim())
            {
                case "": _deprov.Monto_aprobado = 0; break;
                default: _deprov.Monto_aprobado = System.Convert.ToDecimal(line.Substring(178, 15)); break;
            }

            switch (line.Substring(193, 10).Trim())
            {
                case "": _deprov.Fecha_desembolso = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_desembolso = System.Convert.ToDateTime(line.Substring(193, 10)); break;
            }
            
            
            switch (line.Substring(203, 15).Trim())
            {
                case "": _deprov.Monto_Desembolsado = 0; break;
                default: _deprov.Monto_Desembolsado = System.Convert.ToDecimal(line.Substring(203, 15)); break;
            }

            switch (line.Substring(218, 10).Trim())
            {
                case "": _deprov.Fecha_vencimiento = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_vencimiento = System.Convert.ToDateTime(line.Substring(218, 10)); break;
            }

            switch (line.Substring(228, 10).Trim())
            {
                case "": _deprov.Fecha_Ppago = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_Ppago = System.Convert.ToDateTime(line.Substring(228, 10)); break;
            }
            

            switch (line.Substring(238, 15).Trim())
            {
                case "": _deprov.Monto_Cuota = 0; break;
                default: _deprov.Monto_Cuota = System.Convert.ToDecimal(line.Substring(238, 15)); break;
            }
            
            _deprov.Forma_pago_cap = System.Convert.ToChar(line.Substring(253, 1));
            _deprov.Forma_pago_Int = System.Convert.ToChar(line.Substring(254, 1));
            
            switch(line.Substring(255, 2).Trim())
            {
                case "": _deprov.Periodo_gracia=0;break;
                default: _deprov.Periodo_gracia = System.Convert.ToInt32(line.Substring(255, 2)); break;
            }
            switch (line.Substring(257, 6).Trim())
            {
                case "": _deprov.Tasa_int = 0; break;
                default: _deprov.Tasa_int = System.Convert.ToDecimal(line.Substring(257, 6)); break;
            }
            
            _deprov.Tipo_Mon = line.Substring(263, 1);
            _deprov.Cobranza_judicial = System.Convert.ToChar(line.Substring(264, 1));
            _deprov.Clasif_Inicial = System.Convert.ToChar(line.Substring(265, 1));
            _deprov.Clasif_MExp = System.Convert.ToChar(line.Substring(265, 1));
            _deprov.Clasif_MCub = System.Convert.ToChar(line.Substring(267, 1));
            switch (line.Substring(268, 15).Trim())
            {
                case "": _deprov.Prov_req = 0; break;
                default: _deprov.Prov_req = System.Convert.ToDecimal(line.Substring(268, 15)); break;
            }
            
            _deprov.Origen_recursos = line.Substring(283, 2);//deben ser string
            _deprov.Tipo_Vinculo = line.Substring(285, 2);
            switch (line.Substring(287, 15).Trim())
            {
                case "": _deprov.Garantia_adm = 0; break;
                default: _deprov.Garantia_adm = System.Convert.ToDecimal(line.Substring(287, 15)); break;
            }
            
            switch (line.Substring(302, 10).Trim())
            {
                case "": _deprov.Fecha_reestructuracion = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_reestructuracion = System.Convert.ToDateTime(line.Substring(302, 10));break;
            }
            switch (line.Substring(312, 10).Trim())
            {
                case "":_deprov.Fecha_renovacion = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_renovacion = System.Convert.ToDateTime(line.Substring(312, 10));break;
            }
            
            _deprov.Localida = line.Substring(322, 6);

            switch (line.Substring(328, 6).Trim())
            {
                case "": _deprov.Actividad_Deudor = 0; break;
                default: _deprov.Actividad_Deudor = System.Convert.ToInt32(line.Substring(328, 6)); break;
            }
            

            switch (line.Substring(334, 6).Trim())
            {
                case "": _deprov.Destino_cred = 0; break;
                default: _deprov.Destino_cred = System.Convert.ToInt32(line.Substring(334, 6)); break;
            }
            
            _deprov.No_Oficina = line.Substring(340, 5);
            _deprov.Clasif_Riesgo = line.Substring(345, 1);
            _deprov.Cod_pais = line.Substring(346, 2);
            switch (line.Substring(348, 10).Trim())
            {
                case "": _deprov.Fecha_IAdjudicacion  = System.Convert.ToDateTime("1984-04-04");break;
                default: _deprov.Fecha_IAdjudicacion = System.Convert.ToDateTime(line.Substring(348, 10));break;
            }
            
            _deprov.Identificacion_Deu_Conting = line.Substring(358, 15);
            _deprov.Nombre_destinatario = line.Substring(373, 60);
            _deprov.Opcion_pago = line.Substring(433, 2);
            switch (line.Substring(435, 6).Trim())
            {
                case "": _deprov.Penalizacion_pago = 0; break;
                default: _deprov.Penalizacion_pago = System.Convert.ToDecimal(line.Substring(435, 6)); break;
            }

            switch (line.Substring(441, 15).Trim())
            {
                case "": _deprov.Provision_cap = 0; break;
                default: _deprov.Provision_cap = System.Convert.ToDecimal(line.Substring(441, 15)); break;
            }

            switch (line.Substring(456, 15).Trim())
            {
                case "": _deprov.Provision_cap = 0; break;
                default: _deprov.Provision_Rendimientos = System.Convert.ToDecimal(line.Substring(456, 15)); break;
            }
            
            switch (line.Substring(471, 15).Trim())
            {
                case "": _deprov.Provision_Contingencia = 0;break;
                default: _deprov.Provision_Contingencia = System.Convert.ToDecimal(line.Substring(471, 15));break;
            }
            switch (line.Substring(486, 10).Trim())
            {
                case "": _deprov.Fecha_Revision = System.Convert.ToDateTime("1984-04-04");break;
                default: _deprov.Fecha_Revision = System.Convert.ToDateTime(line.Substring(486, 10));break;
            }
            switch (line.Substring(496, 10).Trim())
            {
                case "": _deprov.Fecha_CuotExtr= System.Convert.ToDateTime("1984-04-04");break;
                default: _deprov.Fecha_CuotExtr = System.Convert.ToDateTime(line.Substring(496, 10));break;
            }

            switch (line.Substring(506, 15).Trim())
            {
                case "": _deprov.Monto_CuoExtr = 0;break;
                default: _deprov.Monto_CuoExtr = System.Convert.ToDecimal(line.Substring(506, 15));break;
            }
            switch (line.Substring(521, 3).Trim())
            {
                case "": _deprov.Tipo_cliente = 0;break;
                default: _deprov.Tipo_cliente = System.Convert.ToInt32(line.Substring(521, 3));break;
            }
            switch (line.Substring(524, 3).Trim())
            {
                case "": _deprov.Facilidad_credT78 = 0;break;
                default: _deprov.Facilidad_credT78 = System.Convert.ToInt32(line.Substring(524, 3));break;
            }
            switch (line.Substring(527, 3).Trim())
            {
                case "": _deprov.Cantidad_Plasticos = 0;break;
                default: _deprov.Cantidad_Plasticos = System.Convert.ToInt32(line.Substring(527, 3));break;
            }
            switch (line.Substring(530, 3).Trim())
            {
                case "": _deprov.Codigo_Subproducto = 0;break;
                default: _deprov.Codigo_Subproducto = System.Convert.ToInt32(line.Substring(530, 3));break;
            }
            _deprov.Tip_credito = line.Substring(533, 1);


        }
        private static void llenarDE13(DEPROV _deprov, string line)
        {
            switch (line.Substring(0, 7).Trim())
            {
                case "": _deprov.Numero_secuencial = 0;
                    break;
                default: _deprov.Numero_secuencial = System.Convert.ToInt32(line.Substring(0, 7));
                    break;
            }

            _deprov.Identificacion = line.Substring(7, 15);
            _deprov.Tipo_persona = line.Substring(22, 2);
            _deprov.Nombre = line.Substring(24, 60);
            _deprov.Apellido = line.Substring(84, 30);
            _deprov.Codigo_Credito = line.Substring(114, 27);

            switch (line.Substring(141, 10).Trim())
            {
                case "": _deprov.Fecha_desembolso = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_desembolso = System.Convert.ToDateTime(line.Substring(141, 10)); break;
            }
            
            switch (line.Substring(151, 15).Trim())
            {
                case "": _deprov.Monto_Desembolsado = 0; break;
                default: _deprov.Monto_Desembolsado = System.Convert.ToDecimal(line.Substring(151, 15)); break;
            }
            
            switch (line.Substring(166, 10).Trim())
            {
                case "": _deprov.Fecha_vencimiento = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_vencimiento = System.Convert.ToDateTime(line.Substring(166, 10)); break;
            }

            switch (line.Substring(176, 10).Trim())
            {
                case "": _deprov.Fecha_Ppago = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_Ppago = System.Convert.ToDateTime(line.Substring(176, 10)); break;
            }


            switch (line.Substring(186, 10).Trim())
            {
                case "": _deprov.Monto_Cuota = 0; break;
                default: _deprov.Monto_Cuota = System.Convert.ToDecimal(line.Substring(186, 10)); break;
            }

            switch (line.Substring(196, 6).Trim())
            {
                case "": _deprov.Tasa_int = 0; break;
                default: _deprov.Tasa_int = System.Convert.ToDecimal(line.Substring(196, 6)); break;
            }

            _deprov.Tipo_Mon = line.Substring(202, 1);

            _deprov.Cobranza_judicial = System.Convert.ToChar(line.Substring(203, 1)); 

            _deprov.Clasif_Inicial2 = line.Substring(204, 2);
            
            switch (line.Substring(206, 15).Trim())
            {
                case "": _deprov.Prov_req = 0; break;
                default: _deprov.Prov_req = System.Convert.ToDecimal(line.Substring(206, 15)); break;
            }
             _deprov.Tipo_Vinculo = line.Substring(221, 2); 
             _deprov.Localida = line.Substring(223, 6); 
            _deprov.No_Oficina = line.Substring(229, 5);

            _deprov.Forma_pago_cap = System.Convert.ToChar(line.Substring(234, 1));
            _deprov.Forma_pago_Int = System.Convert.ToChar(line.Substring(235, 1));
            switch (line.Substring(236, 10).Trim())
            {
                case "": _deprov.Fecha_reestructuracion = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_reestructuracion = System.Convert.ToDateTime(line.Substring(236, 10)); break;
            }

            switch (line.Substring(246, 10).Trim())
            {
                case "": _deprov.Fecha_renovacion  = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_renovacion  = System.Convert.ToDateTime(line.Substring(246, 10)); break;
            }


            switch (line.Substring(256, 10).Trim())
            {
                case "": _deprov.Fecha_aprobacion = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_aprobacion = System.Convert.ToDateTime(line.Substring(256, 10)); break;
            }

            switch (line.Substring(266, 15).Trim())
            {
                case "": _deprov.Monto_aprobado = 0; break;
                default: _deprov.Monto_aprobado = System.Convert.ToDecimal(line.Substring(266, 15)); break;
            }

            
            _deprov.Opcion_pago = line.Substring(281, 2);
            switch (line.Substring(283, 6).Trim())
            {
                case "": _deprov.Penalizacion_pago = 0; break;
                default: _deprov.Penalizacion_pago = System.Convert.ToDecimal(line.Substring(283, 6)); break;
            }

            switch (line.Substring(289, 15).Trim())
            {
                case "": _deprov.Provision_cap = 0; break;
                default: _deprov.Provision_cap = System.Convert.ToDecimal(line.Substring(289, 15)); break;
            }
            switch (line.Substring(304, 15).Trim())
            {
                case "": _deprov.Provision_Rendimientos = 0; break;
                default: _deprov.Provision_Rendimientos = System.Convert.ToDecimal(line.Substring(304, 15)); break;
            }


            switch (line.Substring(319, 15).Trim())
            {
                case "": _deprov.Provision_Contingencia = 0; break;
                default: _deprov.Provision_Contingencia = System.Convert.ToDecimal(line.Substring(319, 15)); break;
            }


            switch (line.Substring(334,10).Trim())
            {
                case "": _deprov.Fecha_Revision = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_Revision = System.Convert.ToDateTime(line.Substring(334, 10)); break;
            }

            switch (line.Substring(344, 10).Trim())
            {
                case "": _deprov.Fecha_CuotExtr = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_CuotExtr = System.Convert.ToDateTime(line.Substring(344, 10)); break;
            }
            
            switch (line.Substring(354, 15).Trim())
            {
                case "": _deprov.Monto_CuoExtr = 0; break;
                default: _deprov.Monto_CuoExtr = System.Convert.ToDecimal(line.Substring(354, 15)); break;
            }
            _deprov.Reestructurado = line.Substring(369, 2);
            
            switch (line.Substring(371,3).Trim())
            {
                case "": _deprov.Tipo_cliente = 0; break;
                default: _deprov.Tipo_cliente = System.Convert.ToInt32(line.Substring(371,3));break;
            }
            switch (line.Substring(374, 3).Trim())
            {
                case "": _deprov.Facilidad_credT78 = 0; break;
                default:_deprov.Facilidad_credT78 = System.Convert.ToInt32(line.Substring(374, 3));break;
            }


        }

        private static void llenarDE15(DEPROV _deprov, string line)
        {
            switch (line.Substring(0, 7).Trim())
            {
                case "": _deprov.Numero_secuencial = 0;
                    break;
                default: _deprov.Numero_secuencial = System.Convert.ToInt32(line.Substring(0, 7));
                    break;
            }

            _deprov.Identificacion = line.Substring(7, 15);
            _deprov.Tipo_persona = line.Substring(22, 2);
            _deprov.Nombre = line.Substring(24, 60);
            _deprov.Apellido = line.Substring(84, 30);
            _deprov.Codigo_Credito = line.Substring(114, 27);

            switch (line.Substring(141, 10).Trim())
            {
                case "": _deprov.Fecha_desembolso = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_desembolso = System.Convert.ToDateTime(line.Substring(141, 10)); break;
            }

            switch (line.Substring(151, 15).Trim())
            {
                case "": _deprov.Monto_Desembolsado = 0; break;
                default: _deprov.Monto_Desembolsado = System.Convert.ToDecimal(line.Substring(151, 15)); break;
            }

            switch (line.Substring(166, 10).Trim())
            {
                case "": _deprov.Fecha_vencimiento = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_vencimiento = System.Convert.ToDateTime(line.Substring(166, 10)); break;
            }

            switch (line.Substring(176, 10).Trim())
            {
                case "": _deprov.Fecha_Ppago = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_Ppago = System.Convert.ToDateTime(line.Substring(176, 10)); break;
            }


            switch (line.Substring(186, 10).Trim())
            {
                case "": _deprov.Monto_Cuota = 0; break;
                default: _deprov.Monto_Cuota = System.Convert.ToDecimal(line.Substring(186, 10)); break;
            }

            switch (line.Substring(196, 6).Trim())
            {
                case "": _deprov.Tasa_int = 0; break;
                default: _deprov.Tasa_int = System.Convert.ToDecimal(line.Substring(196, 6)); break;
            }

            _deprov.Tipo_Mon = line.Substring(202, 1);

            _deprov.Cobranza_judicial = System.Convert.ToChar(line.Substring(203, 1));

            _deprov.Clasif_Inicial2 = line.Substring(204, 2);

            switch (line.Substring(206, 15).Trim())
            {
                case "": _deprov.Prov_req = 0; break;
                default: _deprov.Prov_req = System.Convert.ToDecimal(line.Substring(206, 15)); break;
            }
            _deprov.Tipo_Vinculo = line.Substring(221, 2);
            _deprov.Localida = line.Substring(223, 6);
            _deprov.No_Oficina = line.Substring(229, 5);
            //bien
            
              switch(line.Substring(234,10).Trim()) 
              {
                case "":_deprov.Fecha_reestructuracion = System.Convert.ToDateTime("1984-04-04");break;
                default:_deprov.Fecha_reestructuracion = System.Convert.ToDateTime(line.Substring(234, 10));break;
              }

            switch (line.Substring(244, 10).Trim())
            {
                case "": _deprov.Fecha_renovacion = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_renovacion = System.Convert.ToDateTime(line.Substring(244, 10)); break;
            }              
             _deprov.Opcion_pago = line.Substring(254, 2); 
            
            switch (line.Substring(256, 6).Trim())
            {
                case "": _deprov.Penalizacion_pago = 0; break;
                default: _deprov.Penalizacion_pago = System.Convert.ToDecimal(line.Substring(256, 6)); break;
            }
            //bien
            switch (line.Substring(262, 15).Trim())
            {
                case "": _deprov.Provision_cap = 0; break;
                default: _deprov.Provision_cap = System.Convert.ToDecimal(line.Substring(262, 15)); break;
            }
            switch (line.Substring(277, 15).Trim())
            {
                case "": _deprov.Provision_Rendimientos = 0;  break;
                default: _deprov.Provision_Rendimientos = System.Convert.ToDecimal(line.Substring(277, 15)); break;
            }

            switch (line.Substring(292, 10).Trim())
            {
                case "": _deprov.Fecha_Revision = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_Revision = System.Convert.ToDateTime(line.Substring(292, 10)); break;
            }
            switch (line.Substring(302, 10).Trim())
            {
                case "": _deprov.Fecha_CuotExtr = System.Convert.ToDateTime("1984-04-04"); break;
                default: _deprov.Fecha_CuotExtr = System.Convert.ToDateTime(line.Substring(302, 10)); break;
            }

            switch (line.Substring(312, 15).Trim())
            {
                case "": _deprov.Monto_CuoExtr = 0; break;
                default: _deprov.Monto_CuoExtr = System.Convert.ToDecimal(line.Substring(312, 15)); break;
            }

            
             _deprov.Reestructurado = line.Substring(327, 2);

            switch (line.Substring(329, 3).Trim())
            {
                case "": _deprov.Tipo_cliente = 0; break;
                default: _deprov.Tipo_cliente = System.Convert.ToInt32(line.Substring(329, 3)); break;
            }


            switch (line.Substring(332, 3).Trim())
            {
                case "": _deprov.Facilidad_credT78 = 0; break;
                default: _deprov.Facilidad_credT78 = System.Convert.ToInt32(line.Substring(332, 3)); break;
            }
        }
    }
}
