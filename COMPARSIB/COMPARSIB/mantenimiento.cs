using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Drawing;
//using System.Text;
namespace COMPARSIB
{
    class mantenimiento
    {
        public SqlConnection cnt = new SqlConnection();
        public mantenimiento()
        {
            
        }
        public mantenimiento(string server, string txtUsuario, string mtbContrasena, ComboBox cbDatabases)
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
                cnt = con_db;
                con_db.Close();
            }
            catch
            {
                MessageBox.Show("Error en conexión");
            }
        }
        public Boolean GuardaDE11(DEPROV DE11, SqlConnection conn)
        {
            SqlCommand c_GDE11 = new SqlCommand("GuardaDE11", conn);

            c_GDE11.CommandTimeout = 10;
            c_GDE11.CommandType = CommandType.StoredProcedure;
            c_GDE11.Parameters.AddWithValue("@numero_secuencial", DE11.Numero_secuencial);
            c_GDE11.Parameters.AddWithValue("@ident_deu", DE11.Identificacion);
            c_GDE11.Parameters.AddWithValue("@tipo_per", DE11.Tipo_persona);
            c_GDE11.Parameters.AddWithValue("@nombre", DE11.Nombre);
            c_GDE11.Parameters.AddWithValue("@apellido", DE11.Apellido);
            c_GDE11.Parameters.AddWithValue("@codigo_Credito", DE11.Codigo_Credito);
            c_GDE11.Parameters.AddWithValue("@codigo_facilidad", DE11.Codigo_facilidad);
            c_GDE11.Parameters.AddWithValue("@fecha_aprobacion", DE11.Fecha_aprobacion);
            c_GDE11.Parameters.AddWithValue("@monto_aprobado", DE11.Monto_aprobado);
            c_GDE11.Parameters.AddWithValue("@fecha_Desembolso", DE11.Fecha_desembolso);
            c_GDE11.Parameters.AddWithValue("@monto_Desembolsado", DE11.Monto_Desembolsado);
            c_GDE11.Parameters.AddWithValue("@fecha_vencimiento", DE11.Fecha_vencimiento);
            c_GDE11.Parameters.AddWithValue("@fecha_Ppago", DE11.Fecha_Ppago);
            c_GDE11.Parameters.AddWithValue("@monto_Cuota", DE11.Monto_Cuota);
            c_GDE11.Parameters.AddWithValue("@forma_pago_cap", DE11.Forma_pago_cap);
            c_GDE11.Parameters.AddWithValue("@forma_pago_Int", DE11.Forma_pago_Int);
            c_GDE11.Parameters.AddWithValue("@periodo_gracias", DE11.Periodo_gracia);
            c_GDE11.Parameters.AddWithValue("@tasa_int", DE11.Tasa_int);
            c_GDE11.Parameters.AddWithValue("@tipo_Mon", DE11.Tipo_Mon);
            c_GDE11.Parameters.AddWithValue("@cobran_judicial", DE11.Cobranza_judicial);
            c_GDE11.Parameters.AddWithValue("@clasif_Ini", DE11.Clasif_Inicial);
            c_GDE11.Parameters.AddWithValue("@clasif_MExp", DE11.Clasif_MExp);
            c_GDE11.Parameters.AddWithValue("@clasif_MCub", DE11.Clasif_MCub);
            c_GDE11.Parameters.AddWithValue("@prov_req", DE11.Prov_req);
            c_GDE11.Parameters.AddWithValue("@origen_recursos", DE11.Origen_recursos);
            c_GDE11.Parameters.AddWithValue("@tipo_Vinculo", DE11.Tipo_Vinculo);
            c_GDE11.Parameters.AddWithValue("@garantia_adm", DE11.Garantia_adm);
            c_GDE11.Parameters.AddWithValue("@fecha_reestruc", DE11.Fecha_reestructuracion);
            c_GDE11.Parameters.AddWithValue("@fecha_renovac", DE11.Fecha_renovacion);
            c_GDE11.Parameters.AddWithValue("@localidad", DE11.Localida);
            c_GDE11.Parameters.AddWithValue("@act_Deudor", DE11.Actividad_Deudor);
            c_GDE11.Parameters.AddWithValue("@dest_cred", DE11.Destino_cred);
            c_GDE11.Parameters.AddWithValue("@no_Oficina", DE11.No_Oficina);
            c_GDE11.Parameters.AddWithValue("@clasif_riesgo", DE11.Clasif_Riesgo);
            c_GDE11.Parameters.AddWithValue("@cod_pais", DE11.Cod_pais);
            c_GDE11.Parameters.AddWithValue("@fecha_IAdjudicacion", DE11.Fecha_IAdjudicacion);
            c_GDE11.Parameters.AddWithValue("@ident_DestinaConting", DE11.Identificacion_Deu_Conting);
            c_GDE11.Parameters.AddWithValue("@nombre_destinatario", DE11.Nombre_destinatario);
            c_GDE11.Parameters.AddWithValue("@opcion_pago", DE11.Opcion_pago);
            c_GDE11.Parameters.AddWithValue("@penal_pago", DE11.Penalizacion_pago);
            c_GDE11.Parameters.AddWithValue("@provision_cap", DE11.Provision_cap);
            c_GDE11.Parameters.AddWithValue("@prov_rendimientos", DE11.Provision_Rendimientos);
            c_GDE11.Parameters.AddWithValue("@prov_contingencia", DE11.Provision_Contingencia);
            c_GDE11.Parameters.AddWithValue("@fecha_rev", DE11.Fecha_Revision);
            c_GDE11.Parameters.AddWithValue("@fecha_CuotExtr", DE11.Fecha_CuotExtr);
            c_GDE11.Parameters.AddWithValue("@monto_CuoExt", DE11.Monto_CuoExtr);
            c_GDE11.Parameters.AddWithValue("@tipo_cliente", DE11.Tipo_cliente);
            c_GDE11.Parameters.AddWithValue("@facilidad_credT78", DE11.Facilidad_credT78);
            c_GDE11.Parameters.AddWithValue("@cantidad_Plastic", DE11.Cantidad_Plasticos);
            c_GDE11.Parameters.AddWithValue("@cod_Subproducto", DE11.Codigo_Subproducto);
            c_GDE11.Parameters.AddWithValue("@tip_cred", DE11.Tip_credito);
            try
            {
                conn.Open();
                if (c_GDE11.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public Boolean GuardaDE11CLI(DEPROV DE11CLI, SqlConnection conn)
        {
            SqlCommand c_GDE11CLI = new SqlCommand("GuardaDE11CLI", conn);

            c_GDE11CLI.CommandTimeout = 10;
            c_GDE11CLI.CommandType = CommandType.StoredProcedure;
            c_GDE11CLI.Parameters.AddWithValue("@numero_secuencial", DE11CLI.Numero_secuencial);
            c_GDE11CLI.Parameters.AddWithValue("@ident_deu", DE11CLI.Identificacion);
            c_GDE11CLI.Parameters.AddWithValue("@tipo_per", DE11CLI.Tipo_persona);
            c_GDE11CLI.Parameters.AddWithValue("@nombre", DE11CLI.Nombre);
            c_GDE11CLI.Parameters.AddWithValue("@apellido", DE11CLI.Apellido);
            c_GDE11CLI.Parameters.AddWithValue("@codigo_Credito", DE11CLI.Codigo_Credito);
            c_GDE11CLI.Parameters.AddWithValue("@codigo_facilidad", DE11CLI.Codigo_facilidad);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_aprobacion", DE11CLI.Fecha_aprobacion);
            c_GDE11CLI.Parameters.AddWithValue("@monto_aprobado", DE11CLI.Monto_aprobado);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_Desembolso", DE11CLI.Fecha_desembolso);
            c_GDE11CLI.Parameters.AddWithValue("@monto_Desembolsado", DE11CLI.Monto_Desembolsado);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_vencimiento", DE11CLI.Fecha_vencimiento);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_Ppago", DE11CLI.Fecha_Ppago);
            c_GDE11CLI.Parameters.AddWithValue("@monto_Cuota", DE11CLI.Monto_Cuota);
            c_GDE11CLI.Parameters.AddWithValue("@forma_pago_cap", DE11CLI.Forma_pago_cap);
            c_GDE11CLI.Parameters.AddWithValue("@forma_pago_Int", DE11CLI.Forma_pago_Int);
            c_GDE11CLI.Parameters.AddWithValue("@periodo_gracias", DE11CLI.Periodo_gracia);
            c_GDE11CLI.Parameters.AddWithValue("@tasa_int", DE11CLI.Tasa_int);
            c_GDE11CLI.Parameters.AddWithValue("@tipo_Mon", DE11CLI.Tipo_Mon);
            c_GDE11CLI.Parameters.AddWithValue("@cobran_judicial", DE11CLI.Cobranza_judicial);
            c_GDE11CLI.Parameters.AddWithValue("@clasif_Ini", DE11CLI.Clasif_Inicial);
            c_GDE11CLI.Parameters.AddWithValue("@clasif_MExp", DE11CLI.Clasif_MExp);
            c_GDE11CLI.Parameters.AddWithValue("@clasif_MCub", DE11CLI.Clasif_MCub);
            c_GDE11CLI.Parameters.AddWithValue("@prov_req", DE11CLI.Prov_req);
            c_GDE11CLI.Parameters.AddWithValue("@origen_recursos", DE11CLI.Origen_recursos);
            c_GDE11CLI.Parameters.AddWithValue("@tipo_Vinculo", DE11CLI.Tipo_Vinculo);
            c_GDE11CLI.Parameters.AddWithValue("@garantia_adm", DE11CLI.Garantia_adm);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_reestruc", DE11CLI.Fecha_reestructuracion);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_renovac", DE11CLI.Fecha_renovacion);
            c_GDE11CLI.Parameters.AddWithValue("@localidad", DE11CLI.Localida);
            c_GDE11CLI.Parameters.AddWithValue("@act_Deudor", DE11CLI.Actividad_Deudor);
            c_GDE11CLI.Parameters.AddWithValue("@dest_cred", DE11CLI.Destino_cred);
            c_GDE11CLI.Parameters.AddWithValue("@no_Oficina", DE11CLI.No_Oficina);
            c_GDE11CLI.Parameters.AddWithValue("@clasif_riesgo", DE11CLI.Clasif_Riesgo);
            c_GDE11CLI.Parameters.AddWithValue("@cod_pais", DE11CLI.Cod_pais);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_IAdjudicacion", DE11CLI.Fecha_IAdjudicacion);
            c_GDE11CLI.Parameters.AddWithValue("@ident_DestinaConting", DE11CLI.Identificacion_Deu_Conting);
            c_GDE11CLI.Parameters.AddWithValue("@nombre_destinatario", DE11CLI.Nombre_destinatario);
            c_GDE11CLI.Parameters.AddWithValue("@opcion_pago", DE11CLI.Opcion_pago);
            c_GDE11CLI.Parameters.AddWithValue("@penal_pago", DE11CLI.Penalizacion_pago);
            c_GDE11CLI.Parameters.AddWithValue("@provision_cap", DE11CLI.Provision_cap);
            c_GDE11CLI.Parameters.AddWithValue("@prov_rendimientos", DE11CLI.Provision_Rendimientos);
            c_GDE11CLI.Parameters.AddWithValue("@prov_contingencia", DE11CLI.Provision_Contingencia);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_rev", DE11CLI.Fecha_Revision);
            c_GDE11CLI.Parameters.AddWithValue("@fecha_CuotExtr", DE11CLI.Fecha_CuotExtr);
            c_GDE11CLI.Parameters.AddWithValue("@monto_CuoExt", DE11CLI.Monto_CuoExtr);
            c_GDE11CLI.Parameters.AddWithValue("@tipo_cliente", DE11CLI.Tipo_cliente);
            c_GDE11CLI.Parameters.AddWithValue("@facilidad_credT78", DE11CLI.Facilidad_credT78);
            c_GDE11CLI.Parameters.AddWithValue("@cantidad_Plastic", DE11CLI.Cantidad_Plasticos);
            c_GDE11CLI.Parameters.AddWithValue("@cod_Subproducto", DE11CLI.Codigo_Subproducto);
            c_GDE11CLI.Parameters.AddWithValue("@tip_cred", DE11CLI.Tip_credito);
            try
            {
                conn.Open();
                if (c_GDE11CLI.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public Boolean GuardaDE13(DEPROV DE13, SqlConnection conn)
        {
            SqlCommand c_GDE13 = new SqlCommand("GuardaDE13", conn);

            c_GDE13.CommandTimeout = 10;
            c_GDE13.CommandType = CommandType.StoredProcedure;
            c_GDE13.Parameters.AddWithValue("@numero_secuencial", DE13.Numero_secuencial);
            c_GDE13.Parameters.AddWithValue("@ident_deu", DE13.Identificacion);
            c_GDE13.Parameters.AddWithValue("@tipo_per", DE13.Tipo_persona);
            c_GDE13.Parameters.AddWithValue("@nombre", DE13.Nombre);
            c_GDE13.Parameters.AddWithValue("@apellido", DE13.Apellido);
            c_GDE13.Parameters.AddWithValue("@codigo_Credito", DE13.Codigo_Credito);
            c_GDE13.Parameters.AddWithValue("@fecha_Desembolso", DE13.Fecha_desembolso);
            c_GDE13.Parameters.AddWithValue("@monto_Desembolsado", DE13.Monto_Desembolsado);
            c_GDE13.Parameters.AddWithValue("@fecha_vencimiento", DE13.Fecha_vencimiento);
            c_GDE13.Parameters.AddWithValue("@fecha_Ppago", DE13.Fecha_Ppago);
            c_GDE13.Parameters.AddWithValue("@monto_Cuota", DE13.Monto_Cuota);
            c_GDE13.Parameters.AddWithValue("@tipo_Mon", DE13.Tipo_Mon);
            c_GDE13.Parameters.AddWithValue("@tasa_int", DE13.Tasa_int);
            c_GDE13.Parameters.AddWithValue("@cobran_judicial", DE13.Cobranza_judicial);
            c_GDE13.Parameters.AddWithValue("@clasif_Ini", DE13.Clasif_Inicial2);
            c_GDE13.Parameters.AddWithValue("@prov_req", DE13.Prov_req);
            c_GDE13.Parameters.AddWithValue("@tipo_Vinculo", DE13.Tipo_Vinculo);
            c_GDE13.Parameters.AddWithValue("@localidad", DE13.Localida);
            c_GDE13.Parameters.AddWithValue("@no_Oficina", DE13.No_Oficina);
            c_GDE13.Parameters.AddWithValue("@forma_pago_cap", DE13.Forma_pago_cap);
            c_GDE13.Parameters.AddWithValue("@forma_pago_Int", DE13.Forma_pago_Int);
            c_GDE13.Parameters.AddWithValue("@fecha_reestruc", DE13.Fecha_reestructuracion);
            c_GDE13.Parameters.AddWithValue("@fecha_renovac", DE13.Fecha_renovacion);
            c_GDE13.Parameters.AddWithValue("@fecha_aprobacion", DE13.Fecha_aprobacion);
            c_GDE13.Parameters.AddWithValue("@monto_aprobado", DE13.Monto_aprobado);
            c_GDE13.Parameters.AddWithValue("@opcion_pago", DE13.Opcion_pago);
            c_GDE13.Parameters.AddWithValue("@penal_pago", DE13.Penalizacion_pago);
            c_GDE13.Parameters.AddWithValue("@provision_cap", DE13.Provision_cap);
            c_GDE13.Parameters.AddWithValue("@prov_rendimientos", DE13.Provision_Rendimientos);
            c_GDE13.Parameters.AddWithValue("@prov_contingencia", DE13.Provision_Contingencia);
            c_GDE13.Parameters.AddWithValue("@fecha_rev", DE13.Fecha_Revision);
            c_GDE13.Parameters.AddWithValue("@fecha_CuotExtr", DE13.Fecha_CuotExtr);
            c_GDE13.Parameters.AddWithValue("@monto_CuoExt", DE13.Monto_CuoExtr);
            c_GDE13.Parameters.AddWithValue("@reestructurado", DE13.Reestructurado);
            c_GDE13.Parameters.AddWithValue("@tipo_cliente", DE13.Tipo_cliente);
            c_GDE13.Parameters.AddWithValue("@facilidad_credT78", DE13.Facilidad_credT78);
            try
            {
                conn.Open();
                if (c_GDE13.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public Boolean GuardaDE13CLI(DEPROV DE13CLI, SqlConnection conn)
        {
            SqlCommand c_GDE13CLI = new SqlCommand("GuardaDE13CLI", conn);

            c_GDE13CLI.CommandTimeout = 10;
            c_GDE13CLI.CommandType = CommandType.StoredProcedure;
            c_GDE13CLI.Parameters.AddWithValue("@numero_secuencial", DE13CLI.Numero_secuencial);
            c_GDE13CLI.Parameters.AddWithValue("@ident_deu", DE13CLI.Identificacion);
            c_GDE13CLI.Parameters.AddWithValue("@tipo_per", DE13CLI.Tipo_persona);
            c_GDE13CLI.Parameters.AddWithValue("@nombre", DE13CLI.Nombre);
            c_GDE13CLI.Parameters.AddWithValue("@apellido", DE13CLI.Apellido);
            c_GDE13CLI.Parameters.AddWithValue("@codigo_Credito", DE13CLI.Codigo_Credito);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_Desembolso", DE13CLI.Fecha_desembolso);
            c_GDE13CLI.Parameters.AddWithValue("@monto_Desembolsado", DE13CLI.Monto_Desembolsado);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_vencimiento", DE13CLI.Fecha_vencimiento);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_Ppago", DE13CLI.Fecha_Ppago);
            c_GDE13CLI.Parameters.AddWithValue("@monto_Cuota", DE13CLI.Monto_Cuota);
            c_GDE13CLI.Parameters.AddWithValue("@tipo_Mon", DE13CLI.Tipo_Mon);
            c_GDE13CLI.Parameters.AddWithValue("@tasa_int", DE13CLI.Tasa_int);
            c_GDE13CLI.Parameters.AddWithValue("@cobran_judicial", DE13CLI.Cobranza_judicial);
            c_GDE13CLI.Parameters.AddWithValue("@clasif_Ini", DE13CLI.Clasif_Inicial2);
            c_GDE13CLI.Parameters.AddWithValue("@prov_req", DE13CLI.Prov_req);
            c_GDE13CLI.Parameters.AddWithValue("@tipo_Vinculo", DE13CLI.Tipo_Vinculo);
            c_GDE13CLI.Parameters.AddWithValue("@localidad", DE13CLI.Localida);
            c_GDE13CLI.Parameters.AddWithValue("@no_Oficina", DE13CLI.No_Oficina);
            c_GDE13CLI.Parameters.AddWithValue("@forma_pago_cap", DE13CLI.Forma_pago_cap);
            c_GDE13CLI.Parameters.AddWithValue("@forma_pago_Int", DE13CLI.Forma_pago_Int);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_reestruc", DE13CLI.Fecha_reestructuracion);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_renovac", DE13CLI.Fecha_renovacion);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_aprobacion", DE13CLI.Fecha_aprobacion);
            c_GDE13CLI.Parameters.AddWithValue("@monto_aprobado", DE13CLI.Monto_aprobado);
            c_GDE13CLI.Parameters.AddWithValue("@opcion_pago", DE13CLI.Opcion_pago);
            c_GDE13CLI.Parameters.AddWithValue("@penal_pago", DE13CLI.Penalizacion_pago);
            c_GDE13CLI.Parameters.AddWithValue("@provision_cap", DE13CLI.Provision_cap);
            c_GDE13CLI.Parameters.AddWithValue("@prov_rendimientos", DE13CLI.Provision_Rendimientos);
            c_GDE13CLI.Parameters.AddWithValue("@prov_contingencia", DE13CLI.Provision_Contingencia);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_rev", DE13CLI.Fecha_Revision);
            c_GDE13CLI.Parameters.AddWithValue("@fecha_CuotExtr", DE13CLI.Fecha_CuotExtr);
            c_GDE13CLI.Parameters.AddWithValue("@monto_CuoExt", DE13CLI.Monto_CuoExtr);
            c_GDE13CLI.Parameters.AddWithValue("@reestructurado", DE13CLI.Reestructurado);
            c_GDE13CLI.Parameters.AddWithValue("@tipo_cliente", DE13CLI.Tipo_cliente);
            c_GDE13CLI.Parameters.AddWithValue("@facilidad_credT78", DE13CLI.Facilidad_credT78);
            try
            {
                conn.Open();
                if (c_GDE13CLI.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public Boolean GuardaDE15(DEPROV DE15, SqlConnection conn)
        {
            SqlCommand c_GDE15 = new SqlCommand("GuardaDE15", conn);

            c_GDE15.CommandTimeout = 10;
            c_GDE15.CommandType = CommandType.StoredProcedure;
            c_GDE15.Parameters.AddWithValue("@numero_secuencial", DE15.Numero_secuencial);
            c_GDE15.Parameters.AddWithValue("@ident_deu", DE15.Identificacion);
            c_GDE15.Parameters.AddWithValue("@tipo_per", DE15.Tipo_persona);
            c_GDE15.Parameters.AddWithValue("@nombre", DE15.Nombre);
            c_GDE15.Parameters.AddWithValue("@apellido", DE15.Apellido);
            c_GDE15.Parameters.AddWithValue("@codigo_Credito", DE15.Codigo_Credito);
            c_GDE15.Parameters.AddWithValue("@fecha_Desembolso", DE15.Fecha_desembolso);
            c_GDE15.Parameters.AddWithValue("@monto_Desembolsado", DE15.Monto_Desembolsado);
            c_GDE15.Parameters.AddWithValue("@fecha_vencimiento", DE15.Fecha_vencimiento);
            c_GDE15.Parameters.AddWithValue("@fecha_Ppago", DE15.Fecha_Ppago);
            c_GDE15.Parameters.AddWithValue("@monto_Cuota", DE15.Monto_Cuota);
            c_GDE15.Parameters.AddWithValue("@tipo_Mon", DE15.Tipo_Mon);
            c_GDE15.Parameters.AddWithValue("@tasa_int", DE15.Tasa_int);
            c_GDE15.Parameters.AddWithValue("@cobran_judicial", DE15.Cobranza_judicial);
            c_GDE15.Parameters.AddWithValue("@clasif_Ini", DE15.Clasif_Inicial2);
            c_GDE15.Parameters.AddWithValue("@prov_req", DE15.Prov_req);
            c_GDE15.Parameters.AddWithValue("@tipo_Vinculo", DE15.Tipo_Vinculo);
            c_GDE15.Parameters.AddWithValue("@localidad", DE15.Localida);
            c_GDE15.Parameters.AddWithValue("@no_Oficina", DE15.No_Oficina);
            //c_GDE15.Parameters.AddWithValue("@forma_pago_cap", DE15.Forma_pago_cap);
            //c_GDE15.Parameters.AddWithValue("@forma_pago_Int", DE15.Forma_pago_Int);
            c_GDE15.Parameters.AddWithValue("@fecha_reestruc", DE15.Fecha_reestructuracion);
            c_GDE15.Parameters.AddWithValue("@fecha_renovac", DE15.Fecha_renovacion);
            //c_GDE15.Parameters.AddWithValue("@fecha_aprobacion", DE15.Fecha_aprobacion);
            //c_GDE15.Parameters.AddWithValue("@monto_aprobado", DE15.Monto_aprobado);
            c_GDE15.Parameters.AddWithValue("@opcion_pago", DE15.Opcion_pago);
            c_GDE15.Parameters.AddWithValue("@penal_pago", DE15.Penalizacion_pago);
            c_GDE15.Parameters.AddWithValue("@provision_cap", DE15.Provision_cap);
            c_GDE15.Parameters.AddWithValue("@prov_rendimientos", DE15.Provision_Rendimientos);
            //c_GDE15.Parameters.AddWithValue("@prov_contingencia", DE15.Provision_Contingencia);
            c_GDE15.Parameters.AddWithValue("@fecha_rev", DE15.Fecha_Revision);
            c_GDE15.Parameters.AddWithValue("@fecha_CuotExtr", DE15.Fecha_CuotExtr);
            c_GDE15.Parameters.AddWithValue("@monto_CuoExt", DE15.Monto_CuoExtr);
            c_GDE15.Parameters.AddWithValue("@reestructurado", DE15.Reestructurado);
            c_GDE15.Parameters.AddWithValue("@tipo_cliente", DE15.Tipo_cliente);
            c_GDE15.Parameters.AddWithValue("@facilidad_credT78", DE15.Facilidad_credT78);
            try
            {
                conn.Open();
                if (c_GDE15.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public Boolean GuardaDE15CLI(DEPROV DE15CLI, SqlConnection conn)
        {
            SqlCommand c_GDE15CLI = new SqlCommand("GuardaDE15CLI", conn);

            c_GDE15CLI.CommandTimeout = 10;
            c_GDE15CLI.CommandType = CommandType.StoredProcedure;
            c_GDE15CLI.Parameters.AddWithValue("@numero_secuencial", DE15CLI.Numero_secuencial);
            c_GDE15CLI.Parameters.AddWithValue("@ident_deu", DE15CLI.Identificacion);
            c_GDE15CLI.Parameters.AddWithValue("@tipo_per", DE15CLI.Tipo_persona);
            c_GDE15CLI.Parameters.AddWithValue("@nombre", DE15CLI.Nombre);
            c_GDE15CLI.Parameters.AddWithValue("@apellido", DE15CLI.Apellido);
            c_GDE15CLI.Parameters.AddWithValue("@codigo_Credito", DE15CLI.Codigo_Credito);
            c_GDE15CLI.Parameters.AddWithValue("@fecha_Desembolso", DE15CLI.Fecha_desembolso);
            c_GDE15CLI.Parameters.AddWithValue("@monto_Desembolsado", DE15CLI.Monto_Desembolsado);
            c_GDE15CLI.Parameters.AddWithValue("@fecha_vencimiento", DE15CLI.Fecha_vencimiento);
            c_GDE15CLI.Parameters.AddWithValue("@fecha_Ppago", DE15CLI.Fecha_Ppago);
            c_GDE15CLI.Parameters.AddWithValue("@monto_Cuota", DE15CLI.Monto_Cuota);
            c_GDE15CLI.Parameters.AddWithValue("@tipo_Mon", DE15CLI.Tipo_Mon);
            c_GDE15CLI.Parameters.AddWithValue("@tasa_int", DE15CLI.Tasa_int);
            c_GDE15CLI.Parameters.AddWithValue("@cobran_judicial", DE15CLI.Cobranza_judicial);
            c_GDE15CLI.Parameters.AddWithValue("@clasif_Ini", DE15CLI.Clasif_Inicial2);
            c_GDE15CLI.Parameters.AddWithValue("@prov_req", DE15CLI.Prov_req);
            c_GDE15CLI.Parameters.AddWithValue("@tipo_Vinculo", DE15CLI.Tipo_Vinculo);
            c_GDE15CLI.Parameters.AddWithValue("@localidad", DE15CLI.Localida);
            c_GDE15CLI.Parameters.AddWithValue("@no_Oficina", DE15CLI.No_Oficina);
            //c_GDE15.Parameters.AddWithValue("@forma_pago_cap", DE15.Forma_pago_cap);
            //c_GDE15.Parameters.AddWithValue("@forma_pago_Int", DE15.Forma_pago_Int);
            c_GDE15CLI.Parameters.AddWithValue("@fecha_reestruc", DE15CLI.Fecha_reestructuracion);
            c_GDE15CLI.Parameters.AddWithValue("@fecha_renovac", DE15CLI.Fecha_renovacion);
            //c_GDE15.Parameters.AddWithValue("@fecha_aprobacion", DE15.Fecha_aprobacion);
            //c_GDE15.Parameters.AddWithValue("@monto_aprobado", DE15.Monto_aprobado);
            c_GDE15CLI.Parameters.AddWithValue("@opcion_pago", DE15CLI.Opcion_pago);
            c_GDE15CLI.Parameters.AddWithValue("@penal_pago", DE15CLI.Penalizacion_pago);
            c_GDE15CLI.Parameters.AddWithValue("@provision_cap", DE15CLI.Provision_cap);
            c_GDE15CLI.Parameters.AddWithValue("@prov_rendimientos", DE15CLI.Provision_Rendimientos);
            //c_GDE15.Parameters.AddWithValue("@prov_contingencia", DE15.Provision_Contingencia);
            c_GDE15CLI.Parameters.AddWithValue("@fecha_rev", DE15CLI.Fecha_Revision);
            c_GDE15CLI.Parameters.AddWithValue("@fecha_CuotExtr", DE15CLI.Fecha_CuotExtr);
            c_GDE15CLI.Parameters.AddWithValue("@monto_CuoExt", DE15CLI.Monto_CuoExtr);
            c_GDE15CLI.Parameters.AddWithValue("@reestructurado", DE15CLI.Reestructurado);
            c_GDE15CLI.Parameters.AddWithValue("@tipo_cliente", DE15CLI.Tipo_cliente);
            c_GDE15CLI.Parameters.AddWithValue("@facilidad_credT78", DE15CLI.Facilidad_credT78);
            try
            {
                conn.Open();
                if (c_GDE15CLI.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
        public Boolean GuardaDE21(DECNT DE21, SqlConnection conn) 
        {
            SqlCommand c_GDE21 = new SqlCommand("GuardaDE21", conn);


            c_GDE21.CommandTimeout = 10;
            c_GDE21.CommandType = CommandType.StoredProcedure;
            c_GDE21.Parameters.AddWithValue("@No_sec", DE21.Numero_secuencial);
            c_GDE21.Parameters.AddWithValue("@Cod_cred", DE21.Codigo_Credito);
            c_GDE21.Parameters.AddWithValue("@cuenta_cont", DE21.Cuenta_contable);
            c_GDE21.Parameters.AddWithValue("@Monto", DE21.Monto_pendiente);
            c_GDE21.Parameters.AddWithValue("@Dias_atrado", DE21.Dias_atraso);
            c_GDE21.Parameters.AddWithValue("@Num_cuot", DE21.Numero_cuotas);
            c_GDE21.Parameters.AddWithValue("@T_moneda", DE21.Tipo_moneda);
            
            try
            {
                conn.Open();
                if (c_GDE21.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
			
            return false;
        }

        public Boolean GuardaDE21CLI(DECNT DE21CLI, SqlConnection conn)
        {
            SqlCommand c_GDE21CLI = new SqlCommand("GuardaDE21CLI", conn);


            c_GDE21CLI.CommandTimeout = 10;
            c_GDE21CLI.CommandType = CommandType.StoredProcedure;
            c_GDE21CLI.Parameters.AddWithValue("@No_sec", DE21CLI.Numero_secuencial);
            c_GDE21CLI.Parameters.AddWithValue("@Cod_cred", DE21CLI.Codigo_Credito);
            c_GDE21CLI.Parameters.AddWithValue("@cuenta_cont", DE21CLI.Cuenta_contable);
            c_GDE21CLI.Parameters.AddWithValue("@Monto", DE21CLI.Monto_pendiente);
            c_GDE21CLI.Parameters.AddWithValue("@Dias_atrado", DE21CLI.Dias_atraso);
            c_GDE21CLI.Parameters.AddWithValue("@Num_cuot", DE21CLI.Numero_cuotas);
            c_GDE21CLI.Parameters.AddWithValue("@T_moneda", DE21CLI.Tipo_moneda);

            try
            {
                conn.Open();
                if (c_GDE21CLI.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public Boolean GuardaDE25(DECNT DE25, SqlConnection conn)
        {
            SqlCommand c_GDE25 = new SqlCommand("dbo.GuardaDE25", conn);


            c_GDE25.CommandTimeout = 10;
            c_GDE25.CommandType = CommandType.StoredProcedure;
            c_GDE25.Parameters.AddWithValue("@No_sec", DE25.Numero_secuencial);
            c_GDE25.Parameters.AddWithValue("@Cod_cred", DE25.Codigo_Credito);
            c_GDE25.Parameters.AddWithValue("@cuenta_cont", DE25.Cuenta_contable);
            c_GDE25.Parameters.AddWithValue("@Monto", DE25.Monto_pendiente);
            c_GDE25.Parameters.AddWithValue("@Dias_atrado", DE25.Dias_atraso);
            c_GDE25.Parameters.AddWithValue("@Num_cuot", DE25.Numero_cuotas);

            try
            {
                conn.Open();
                if (c_GDE25.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public Boolean GuardaDE25CLI(DECNT DE25CLI, SqlConnection conn)
        {
            SqlCommand c_GDE25CLI = new SqlCommand("dbo.GuardaDE25CLI", conn);


            c_GDE25CLI.CommandTimeout = 10;
            c_GDE25CLI.CommandType = CommandType.StoredProcedure;
            c_GDE25CLI.Parameters.AddWithValue("@No_sec", DE25CLI.Numero_secuencial);
            c_GDE25CLI.Parameters.AddWithValue("@Cod_cred", DE25CLI.Codigo_Credito);
            c_GDE25CLI.Parameters.AddWithValue("@cuenta_cont", DE25CLI.Cuenta_contable);
            c_GDE25CLI.Parameters.AddWithValue("@Monto", DE25CLI.Monto_pendiente);
            c_GDE25CLI.Parameters.AddWithValue("@Dias_atrado", DE25CLI.Dias_atraso);
            c_GDE25CLI.Parameters.AddWithValue("@Num_cuot", DE25CLI.Numero_cuotas);

            try
            {
                conn.Open();
                if (c_GDE25CLI.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }
       
        public Boolean GuardaDE23(DECNT DE23, SqlConnection conn)
        {
            SqlCommand c_GDE25 = new SqlCommand("dbo.GuardaDE23", conn);


            c_GDE25.CommandTimeout = 10;
            c_GDE25.CommandType = CommandType.StoredProcedure;
            c_GDE25.Parameters.AddWithValue("@No_sec", DE23.Numero_secuencial);
            c_GDE25.Parameters.AddWithValue("@Cod_cred", DE23.Codigo_Credito);
            c_GDE25.Parameters.AddWithValue("@cuenta_cont", DE23.Cuenta_contable);
            c_GDE25.Parameters.AddWithValue("@Monto", DE23.Monto_pendiente);
            c_GDE25.Parameters.AddWithValue("@Dias_atrado", DE23.Dias_atraso);
            c_GDE25.Parameters.AddWithValue("@Num_cuot", DE23.Numero_cuotas);

            try
            {
                conn.Open();
                if (c_GDE25.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        
        }

        public Boolean GuardaDE23CLI(DECNT DE23CLI, SqlConnection conn)
        {
            SqlCommand c_GDE25CLI = new SqlCommand("dbo.GuardaDE23CLI", conn);


            c_GDE25CLI.CommandTimeout = 10;
            c_GDE25CLI.CommandType = CommandType.StoredProcedure;
            c_GDE25CLI.Parameters.AddWithValue("@No_sec", DE23CLI.Numero_secuencial);
            c_GDE25CLI.Parameters.AddWithValue("@Cod_cred", DE23CLI.Codigo_Credito);
            c_GDE25CLI.Parameters.AddWithValue("@cuenta_cont", DE23CLI.Cuenta_contable);
            c_GDE25CLI.Parameters.AddWithValue("@Monto", DE23CLI.Monto_pendiente);
            c_GDE25CLI.Parameters.AddWithValue("@Dias_atrado", DE23CLI.Dias_atraso);
            c_GDE25CLI.Parameters.AddWithValue("@Num_cuot", DE23CLI.Numero_cuotas);

            try
            {
                conn.Open();
                if (c_GDE25CLI.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;

        }


        public Boolean BorraDE(int DE, SqlConnection conn)
        {
            SqlCommand c_BDE = new SqlCommand("BorraDE", conn);


            c_BDE.CommandTimeout = 10;
            c_BDE.CommandType = CommandType.StoredProcedure;
            c_BDE.Parameters.AddWithValue("@DE", DE);

            try
            {
                conn.Open();
                if (c_BDE.ExecuteNonQuery() >= 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false;
        }

        public Boolean Combinar(string qry, SqlConnection conn) 
        {
            //Listar las Bases de datos 
            SqlCommand com_db = new SqlCommand();
            com_db.CommandText = qry;
            com_db.Connection = conn;
            try
            {
                conn.Open();
                if (com_db.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return false; 
  

        }
        /*
         
//PROCEDIMIENTO PARA INSERTAR EN EL DE25
IF EXISTS(SELECT 1 FROM SYS.objects WHERE name = 'GuardaDE21')
DROP PROCEDURE GuardaDE21
GO 
Create procedure GuardaDE21(@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int,
							@T_moneda char(1))
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE21Banke')
		 begin 
			   create table DE21Banke (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE21Banke(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,T_moneda,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,@T_moneda,NULL)
  end
  Go
  

   //PROCEDIMIENTO PARA INSERTAR EN EL DE23
  IF EXISTS(SELECT 1 FROM SYS.objects WHERE name = 'GuardaDE23')
DROP PROCEDURE GuardaDE23
GO 
Create procedure GuardaDE23(@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int
							--@T_moneda char(1)
							)
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE23Banke')
		 begin 
			   create table DE23Banke (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										--T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE23Banke(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,NULL)
  end
  Go



//PROCEDIMIENTO PARA INSERTAR EN EL DE25
  IF EXISTS(SELECT 1 FROM SYS.objects WHERE name = 'GuardaDE25')
DROP PROCEDURE GuardaDE25
GO 
Create procedure GuardaDE25(@No_sec int, 
                            @Cod_cred varchar(27),
							@cuenta_cont varchar(35),
							@Monto decimal(15,2),
							@Dias_atrado int,
							@Num_cuot int
							--@T_moneda char(1)
							)
   as 
begin
			if not exists(select 1 from sys.objects where name = 'DE25Banke')
		 begin 
			   create table DE25Banke (	No_sec int NULL,
										cod_cred varchar(27) NULL,
										cuecta_cont varchar(80) NULL,
										monto decimal(10, 2) NULL,
										dia_atraso int NULL,
										Num_cuot int NULL,
										--T_moneda char(1) NULL,
										referencia varchar(20) NULL
									)
		   end 
   insert into DE25Banke(No_sec,cod_cred,cuecta_cont,monto,dia_atraso,Num_cuot,referencia)
        values (@No_sec,@Cod_cred,@cuenta_cont,@Monto,@Dias_atrado,@Num_cuot,NULL)
  end
  Go

  //BORRAR LAS TABLAS DE LOS DE
  IF EXISTS(SELECT 1 FROM SYS.objects WHERE name = 'BorraDE')
DROP PROCEDURE BorraDE
GO 
Create procedure BorraDE(@DE int)
   as 
begin
     if @DE = 21 
  begin
			if exists(select 1 from sys.objects where name = 'DE21Banke')
		 begin 
			   Delete DE21Banke
		   end 
    end
   
     if @DE = 23 
  begin
			if exists(select 1 from sys.objects where name = 'DE23Banke')
		 begin 
			   Delete DE23Banke
		   end 
    end
     if @DE = 25 
  begin
			if exists(select 1 from sys.objects where name = 'DE25Banke')
		 begin 
			   Delete DE25Banke
		   end 
    end

  end

  
         */

    }
}
