using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilder.Models
{
    public class Cuenta
    {
        public int NumeroCuenta { get; set; }
        public double SaldoInicial { get; set; }
        public string Propietario { get; set; }
        public double TasaPreferencial { get; set; }
        public TipoDeCuentaEnum TipoDeCuenta { get; set; }

        public Cuenta()
        {
            
        }

        public Cuenta(TipoDeCuentaEnum tipoDeCuenta, int numeroCuenta, double saldoInicial, string propietario, double tasaPreferencial)
        {
            TipoDeCuenta = tipoDeCuenta;
            NumeroCuenta = numeroCuenta;
            SaldoInicial = saldoInicial;
            Propietario = propietario;
            TasaPreferencial = tasaPreferencial;
        }

        public override string ToString()
        {
            return $"Cuenta {NumeroCuenta} / Saldo: {SaldoInicial}, Propietario: {Propietario}, Tasa preferencial: {TasaPreferencial}, Tipo de Cuenta: {TipoDeCuenta}";
        }
    }
}
