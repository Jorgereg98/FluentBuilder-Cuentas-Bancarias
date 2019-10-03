using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBuilder.Models;

namespace FluentBuilder.Builder
{
    public class CuentaFluentBuilder
    {
        private readonly Cuenta _cuenta;

        public static CuentaFluentBuilder Crear(TipoDeCuentaEnum tipo)
        {
            return new CuentaFluentBuilder(tipo);
        }

        private CuentaFluentBuilder(TipoDeCuentaEnum tipo)
        {
            _cuenta = new Cuenta { TipoDeCuenta = tipo};
        }

        public CuentaFluentBuilder DefinirNumeroDeCuenta(int numero)
        {
            _cuenta.NumeroCuenta = numero;
            return this;
        }

        public CuentaFluentBuilder DefinirSaldoInicial(double numero)
        {
            _cuenta.SaldoInicial = numero;
            return this;
        }

        public CuentaFluentBuilder DefinirNombreDelPropietario(string nombre)
        {
            _cuenta.Propietario = nombre;
            return this;
        }

        public CuentaFluentBuilder DefinirTasaPreferencial(double numero)
        {
            _cuenta.TasaPreferencial = numero;
            return this;
        }

        public Cuenta Finalizar()
        {
            return _cuenta;
        }
    }
}
