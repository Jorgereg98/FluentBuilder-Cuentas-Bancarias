using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentBuilder.Builder;
using FluentBuilder.Models;

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Form1 interfaz = new Form1();
            interfaz.ShowDialog();
            /*Cuenta cuenta_personalizada = CuentaFluentBuilder.Crear(TipoDeCuentaEnum.Golden)
                .DefinirNumeroDeCuenta(1234)
                .DefinirSaldoInicial(100000)
                .DefinirNombreDelPropietario("Jorge Ruiz")
                .DefinirTasaPreferencial(10)
                .Finalizar();

            Console.WriteLine(cuenta_personalizada.ToString());

            Console.ReadKey();
            */
        }
    }
}
