using System;
using System.Collections.Generic;
using System.Text;

namespace COMPARSIB
{
    class DECNT
    {
        private int _numero_secuencial;
        private string _codigo_Credito;
        private string _cuenta_contable;   
        private decimal _monto_pendiente;
        private int _dias_atraso;
        private int _numero_cuotas;
        private char _tipo_moneda;


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

        public string Cuenta_contable
        {
            get { return _cuenta_contable; }
            set { _cuenta_contable = value; }
        }
        public decimal Monto_pendiente
        {
            get { return _monto_pendiente; }
            set { _monto_pendiente = value; }
        }

        public int Dias_atraso
        {
            get { return _dias_atraso; }
            set { _dias_atraso = value; }
        }

        public int Numero_cuotas
        {
            get { return _numero_cuotas; }
            set { _numero_cuotas = value; }
        }
        
        public char Tipo_moneda
        {
            get { return _tipo_moneda; }
            set { _tipo_moneda = value; }
        }
    }
}
