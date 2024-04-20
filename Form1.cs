using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Palindromo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Verificar_Click(object sender, EventArgs e)
        {
            string palabra1 = Palabra1.Text;
            string palabra2 = Palabra2.Text;


            Thread hilo1 = new Thread(() => VerificarPalindromo(palabra1));
            Thread hilo2 = new Thread(() => VerificarPalindromo(palabra2));

            hilo1.Start();
            hilo2.Start();
        }

        private void VerificarPalindromo(string palabra)
        {
            string palabraInvertida = InvertirPalabra(palabra);
            bool esPalindromo = palabra.Equals(palabraInvertida, StringComparison.OrdinalIgnoreCase);

          
            string mensaje = $"La palabra '{palabra}' {(esPalindromo ? "es" : "no es")} un palíndromo.";
            MessageBox.Show(mensaje);
        }

        private string InvertirPalabra(string palabra)
        {
            char[] caracteres = palabra.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}