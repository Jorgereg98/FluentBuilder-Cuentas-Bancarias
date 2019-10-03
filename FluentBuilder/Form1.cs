using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentBuilder.Builder;
using FluentBuilder.Models;

namespace FluentBuilder
{
    public partial class Form1 : Form
    {
        List<Cuenta> lista = new List<Cuenta>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cuenta cuenta_personalizada = CuentaFluentBuilder.Crear((TipoDeCuentaEnum)Enum.Parse(typeof(TipoDeCuentaEnum), comboBox1.SelectedItem.ToString()))
                .DefinirNumeroDeCuenta(Convert.ToInt32(textBox1.Text))
                .DefinirNombreDelPropietario(textBox2.Text)
                .DefinirTasaPreferencial(Convert.ToDouble(textBox3.Text))
                .DefinirSaldoInicial(Convert.ToDouble(textBox4.Text))
                .Finalizar();

                lista.Add(cuenta_personalizada);
                MessageBox.Show("Cuenta generada con éxito");

                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
            }
            catch
            {
                MessageBox.Show("Los datos están incorrectos o incompletos");
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
            }
            finally
            {
                var source = new BindingSource(lista, null);
                dataGridView1.DataSource = source;
            }
            
        }
    }
}
