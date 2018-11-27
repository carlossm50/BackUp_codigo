using System;
using System.Collections.Generic;
using System.Text;

namespace COMPARSIB
{
    class DEPROV
    {
        private int _numero_secuencial;
        private string _ident_deu;
        private string _tipo_per;
        private string _nombre;
        private string _apellido;
        private string _codigo_Credito;
        private string _codigo_facilidad;
        private DateTime _fecha_aprobacion;
        private decimal _monto_aprobado;
        private DateTime _fecha_Desembolso;
        private decimal _monto_Desembolsado;
        private DateTime _fecha_vencimiento;
        private DateTime _fecha_Ppago;
        private decimal _monto_Cuota;
        private char _forma_pago_cap;
        private char _forma_pago_Int;
        private int _periodo_gracias;
        private decimal _tasa_int;
        private string _tipo_Mon;
        private char _cobran_judicial;
        private char _clasif_Ini;
        private string _clasif_Ini2;
        private char _clasif_MExp;
        private char _clasif_MCub;
        private decimal _prov_req;
        private string _origen_recursos;
        private string _tipo_Vinculo;
        private decimal _garantia_adm;
        private DateTime _fecha_reestruc;
        private DateTime _fecha_renovac;
        private string _localidad;
        private int _act_Deudor;
        private int _dest_cred;
        private string _no_Oficina;
        private string _clasif_riesgo;
        private string _cod_pais;
        private DateTime _fecha_IAdjudicacion;
        private string _ident_DestinaConting;
        private string _nombre_destinatario;
        private string _opcion_pago;
        private decimal _penal_pago;
        private decimal _provision_cap;
        private decimal _prov_rendimientos;
        private decimal _prov_contingencia;
        private DateTime _fecha_rev;
        private DateTime _fecha_CuotExtr;
        private decimal _monto_CuoExt;
        private int _tipo_cliente;
        private int _facilidad_credT78;
        private int _cantidad_Plastic;
        private int _cod_Subproducto;
        private string _tip_cred;
        private string _reestructurado;

        public int Numero_secuencial
        {
            get { return _numero_secuencial; }
            set { _numero_secuencial = value; }
        }
        public string Codigo_Credito
        {
            get { return _codigo_Credito; }
            set { _codigo_Credito = value; }
        }
        public string Identificacion
        {
            get { return _ident_deu; }
            set { _ident_deu = value; }
        }
        public string Tipo_persona
        {
            get { return _tipo_per; }
            set { _tipo_per = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public string Codigo_facilidad
        {
            get { return _codigo_facilidad; }
            set { _codigo_facilidad = value; }
        }
        public DateTime Fecha_aprobacion 
        {
            get { return _fecha_aprobacion; }
            set { _fecha_aprobacion = value; }
        }
        public decimal Monto_aprobado
        {
            get { return _monto_aprobado; }
            set { _monto_aprobado = value; }
        }
        public decimal Monto_CuoExtr
        {
            get { return _monto_CuoExt; }
            set { _monto_CuoExt = value; }
        }
        public DateTime Fecha_desembolso
        {
            get { return _fecha_Desembolso; }
            set { _fecha_Desembolso = value; }
        }
        public decimal Monto_Desembolsado
        {
            get { return _monto_Desembolsado; }
            set { _monto_Desembolsado = value; }
        }
        public DateTime Fecha_vencimiento
        {
            get { return _fecha_vencimiento; }
            set { _fecha_vencimiento = value; }
        }
        public DateTime Fecha_Ppago
        {
            get { return _fecha_Ppago; }
            set { _fecha_Ppago = value; }
        }
        public decimal Monto_Cuota
        {
            get { return _monto_Cuota; }
            set { _monto_Cuota = value; }
        }
        public char Forma_pago_cap
        {
            get { return _forma_pago_cap; }
            set { _forma_pago_cap = value; }
        }
        public char Forma_pago_Int
        {
            get { return _forma_pago_Int; }
            set { _forma_pago_Int = value; }
        }
        public int Periodo_gracia
        {
            get { return _periodo_gracias; }
            set { _periodo_gracias = value; }
        }
        public decimal Tasa_int
        {
            get { return _tasa_int; }
            set { _tasa_int = value; }
        }
        public string Tipo_Mon
        {
            get { return _tipo_Mon; }
            set { _tipo_Mon = value; }
        }
        public char Cobranza_judicial
        {
            get { return _cobran_judicial; }
            set { _cobran_judicial = value; }
        }
        public char Clasif_Inicial
        {
            get { return _clasif_Ini; }
            set { _clasif_Ini = value; }
        }
        public string Clasif_Inicial2
        {
            get { return _clasif_Ini2; }
            set { _clasif_Ini2 = value; }
        }
        public char Clasif_MExp
        {
            get { return _clasif_MExp; }
            set { _clasif_MExp = value; }
        }
        public char Clasif_MCub
        {
            get { return _clasif_MCub; }
            set { _clasif_MCub = value; }
        }
        public decimal Prov_req
        {
            get { return _prov_req; }
            set { _prov_req = value; }
        }
        public string Origen_recursos
        {
            get { return _origen_recursos; }
            set { _origen_recursos = value; }
        }
        public string Tipo_Vinculo
        {
            get { return _tipo_Vinculo; }
            set { _tipo_Vinculo = value; }
        }
        public decimal Garantia_adm
        {
            get { return _garantia_adm; }
            set { _garantia_adm = value; }
        }
        public DateTime Fecha_reestructuracion
        {
            get { return _fecha_reestruc; }
            set { _fecha_reestruc = value; }
        }
        public DateTime Fecha_renovacion
        {
            get { return _fecha_renovac; }
            set { _fecha_renovac = value; }
        }
        public string Localida
        {
            get { return _localidad; }
            set { _localidad = value; }
        }
        public int Actividad_Deudor
        {
            get { return _act_Deudor; }
            set { _act_Deudor = value; }
        }
        public int Destino_cred
        {
            get { return _dest_cred; }
            set { _dest_cred = value; }
        }
        public string No_Oficina
        {
            get { return _no_Oficina; }
            set { _no_Oficina = value; }
        }
        public string Clasif_Riesgo
        {
            get { return _clasif_riesgo; }
            set { _clasif_riesgo = value; }
        }
        public string Cod_pais
        {
            get { return _cod_pais; }
            set { _cod_pais = value; }
        }
        public DateTime Fecha_IAdjudicacion
        {
            get { return _fecha_IAdjudicacion; }
            set { _fecha_IAdjudicacion = value; }
        }
        public string Identificacion_Deu_Conting
        {
            get { return _ident_DestinaConting; }
            set { _ident_DestinaConting = value; }
        }
        public string Nombre_destinatario
        {
            get { return _nombre_destinatario; }
            set { _nombre_destinatario = value; }
        }
        public string Opcion_pago
        {
            get { return _opcion_pago; }
            set { _opcion_pago = value; }
        }
        public decimal Penalizacion_pago
        {
            get { return _penal_pago; }
            set { _penal_pago = value; }
        }
        public decimal Provision_cap
         {
             get { return _provision_cap; }
             set { _provision_cap = value; }
         }
        public decimal Provision_Rendimientos
         {
             get { return _prov_rendimientos; }
             set { _prov_rendimientos = value; }
         }
        public decimal Provision_Contingencia
        {
            get { return _prov_contingencia; }
            set { _prov_contingencia = value; }
        }
        public DateTime Fecha_Revision
        {
            get { return _fecha_rev; }
            set { _fecha_rev = value; }
        }
        public DateTime Fecha_CuotExtr
        {
            get { return _fecha_CuotExtr; }
            set { _fecha_CuotExtr = value; }
        }                
        public int Tipo_cliente
        {
            get { return _tipo_cliente; }
            set { _tipo_cliente = value; }
        }
        public int Facilidad_credT78
        {
            get { return _facilidad_credT78; }
            set { _facilidad_credT78 = value; }
        }
        public int Cantidad_Plasticos
        {
            get { return _cantidad_Plastic; }
            set { _cantidad_Plastic = value; }
        }
        public int Codigo_Subproducto
        {
            get { return _cod_Subproducto; }
            set { _cod_Subproducto = value; }
        }
        public string Tip_credito
        {
            get { return _tip_cred; }
            set { _tip_cred = value; }
        }
        public string Reestructurado
        {
            get { return _reestructurado; }
            set { _reestructurado = value; }
        }
    }
}