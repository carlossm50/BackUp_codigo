using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace COMPARSIB
{
    
    public partial class frmLoging : Form
    {
        //Variables locales
        public SqlConnection cnt = new SqlConnection();
        public string  usuario = "";
        public string clave = "";
        public string  serverSQL = "";
        public frmLoging(SqlConnection cnt)
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLoging_Load(object sender, EventArgs e)
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

        private void cbServers_SelectedValueChanged(object sender, EventArgs e)
        {
           // mantenimiento man = new mantenimiento(cbServers.Text, txtUsuario.Text, mtbContrasena.Text, cbDatabases);
        }

        private void txtUsuario_Validating(object sender, CancelEventArgs e)
        {
            if (txtUsuario.Text.Trim() == string.Empty || mtbContrasena.Text.Trim() == string.Empty)
            {
                cbDatabases.Enabled = false;
            }
            else
            {
                mantenimiento man = new mantenimiento(cbServers.Text, txtUsuario.Text, mtbContrasena.Text, cbDatabases);
                cbDatabases.Enabled = true;
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

        private void cbServers_Validating_1(object sender, CancelEventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.cnt.ConnectionString = "user id=" + txtUsuario.Text + ";data source=" + cbServers.Text + ";persist security info=True;initial catalog=" + cbDatabases.Text + ";password=" + mtbContrasena.Text;
            usuario = txtUsuario.Text;
            clave = mtbContrasena.Text;
            serverSQL = cbServers.Text;
            this.Close();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            SqlDataSourceEnumerator servers = SqlDataSourceEnumerator.Instance;
            DataTable serversTable = servers.GetDataSources();
            cbServers.Items.Clear();
            foreach (DataRow row in serversTable.Rows)
            {
                string serverName = row["ServerName"].ToString();
                string InstanceName = @"\" + row["InstanceName"].ToString();
                //MessageBox.Show(serverName+InstanceName);
                cbServers.Items.Add(serverName + InstanceName);
            }
        }
    }
}
