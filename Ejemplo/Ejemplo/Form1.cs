using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace Ejemplo
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Listar las instancias de SQL Sever que existen en la maquina

            SqlDataSourceEnumerator servers = SqlDataSourceEnumerator.Instance;
            DataTable serversTable = servers.GetDataSources();

            foreach (DataRow row in serversTable.Rows)
            {
                string serverName = row["ServerName"].ToString();
                string InstanceName = @"\" + row["InstanceName"].ToString();
                //MessageBox.Show(serverName+InstanceName);
                cbServers.Items.Add(serverName + InstanceName);
            }
        }

        private void cbServers_Validating(object sender, CancelEventArgs e)
        {

            if (cbServers.Text.Trim() == string.Empty)
            {
                txtUsuario.Enabled = false;
                mtbContrasena.Enabled = false;
                cbDatabases.Enabled = false;

            }
            else
            {
                txtUsuario.Enabled = true;
                mtbContrasena.Enabled = true;
                cbDatabases.Enabled = true;

            }
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Trim() == string.Empty || mtbContrasena.Text.Trim() == string.Empty)
            {
                cbDatabases.Enabled = false;
            }
            else
            {
             /*   mantenimiento man = new mantenimiento(cbServers.Text, txtUsuario.Text, mtbContrasena.Text, cbDatabases);*/
                cbDatabases.Enabled = true;
            }
        }

        private void mtbContrasena_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Trim() == string.Empty || mtbContrasena.Text.Trim() == string.Empty)
            {
                cbDatabases.Enabled = false;
            }
            else
            {
                Bucar_DB(cbDatabases, txtUsuario.Text, cbServers.Text, mtbContrasena.Text);
//                "user id=" + txtUsuario + ";data source=" + server + ";persist security info=True;initial catalog=master;password=" + mtbContrasena;
                cbDatabases.Enabled = true;
            }
        }

        private void btnCrearTBL_Click(object sender, EventArgs e)
        {
            
            conn.ConnectionString = "user id=" + txtUsuario.Text + ";data source=" + cbServers.Text + ";persist security info=True;initial catalog=" + cbDatabases.Text + ";password=" + mtbContrasena.Text;
            SqlCommand Comando = new SqlCommand("if not exists (select 1 from sys.objects where name = 'TBLClientes')" +
                                                    "begin "+
                                                    "create table TBLClientes(id int identity, cedula varchar(13),nombre varchar(100),apellido varchar(100),edad int )" +
                                                    "end ", conn);

            try
            {
                conn.Open();
                Comando.ExecuteNonQuery();
                MessageBox.Show("Tabla creada exitosamente.");  
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static void Bucar_DB(ComboBox cbDatabases, String txtUsuario, string server, string mtbContrasena)
        {
            //Listar las Bases de datos 
            SqlConnection con_db = new SqlConnection();
            SqlCommand com_db = new SqlCommand();

            con_db.ConnectionString = "user id="+txtUsuario+";data source=" + server + ";persist security info=True;initial catalog=master;password=" + mtbContrasena;
            
            com_db.CommandText = "select name from sys.databases";
            com_db.Connection = con_db;
            cbDatabases.Items.Clear();
            try
            {
                con_db.Open();
                SqlDataReader dr_db = com_db.ExecuteReader();
                cbDatabases.Items.Add(" ");

                while (dr_db.Read())
                {
                    cbDatabases.Items.Add(dr_db.GetString(0));
                }
                con_db.Close();
            }
            catch
            {
                MessageBox.Show("Error en conexión");
                Application.Exit();
            }
        
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = "user id=" + txtUsuario.Text + ";data source=" + cbServers.Text + ";persist security info=True;initial catalog=" + cbDatabases.Text + ";password=" + mtbContrasena.Text;
            SqlCommand Comando = new SqlCommand("insert into TBLClientes(Cedula ,nombre ,Apellido ,edad ) values('"+txtcedula.Text+"','"+txtnombre.Text+"','"+txtapellido.Text+"',"+txtedad.Text+")", conn);
            SqlDataAdapter adat = new SqlDataAdapter("select * from TBLClientes", conn);
            DataTable tbl = new DataTable();

            if (txtcedula.Text == String.Empty)
            {

                MessageBox.Show("La cédula no debe estar en blanco.", "abvertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtcedula.Focus();
                return;
            }
            if (txtnombre.Text == String.Empty) 
            {

                MessageBox.Show("El nombre no debe estar en blanco.", "abvertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtnombre.Focus();
                return;
            }
            if (txtapellido.Text == String.Empty)
            {

                MessageBox.Show("El apellido no debe estar en blanco.", "abvertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtapellido.Focus();
                return;
            }
            if (txtedad.Text == String.Empty)
            {

                MessageBox.Show("Debe indicar la edad.", "abvertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtedad.Focus();
                return;
            }
            try
            {
                conn.Open();
                if (Comando.ExecuteNonQuery() > 0)
                {
                    adat.Fill(tbl);
                    DTgridCliente.AutoGenerateColumns = false;
                    DTgridCliente.DataSource =tbl ;
 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + Comando.CommandText);
            }
            finally
            {
                conn.Close();
            }

        }

        private void btnrefrescar_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = "user id=" + txtUsuario.Text + ";data source=" + cbServers.Text + ";persist security info=True;initial catalog=" + cbDatabases.Text + ";password=" + mtbContrasena.Text;
            SqlDataAdapter adat = new SqlDataAdapter("select * from TBLClientes", conn);
            DataTable tbl = new DataTable();
            try
            {
                conn.Open();
                adat.Fill(tbl);
                DTgridCliente.AutoGenerateColumns = false;
                DTgridCliente.DataSource = tbl;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            conn.ConnectionString = "user id=" + txtUsuario.Text + ";data source=" + cbServers.Text + ";persist security info=True;initial catalog=" + cbDatabases.Text + ";password=" + mtbContrasena.Text;
            SqlCommand Comando = new SqlCommand("delete TBLClientes where id =" + DTgridCliente.SelectedRows[0].Cells[0].Value.ToString(), conn);
            SqlDataAdapter adat = new SqlDataAdapter("select * from TBLClientes", conn);
            DataTable tbl = new DataTable();
            try
            {
                conn.Open();
                if (Comando.ExecuteNonQuery() > 0)
                {
                    adat.Fill(tbl);
                    DTgridCliente.AutoGenerateColumns = false;
                    DTgridCliente.DataSource = tbl;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + Comando.CommandText);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
