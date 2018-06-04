using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace Compi
{
    public partial class FormaPrincipal : MetroForm
    {
        public FormaPrincipal()
        {
            InitializeComponent();
        }

        public List<Nodo> listaNodos;


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void MetroBtnLexico_Click(object sender, EventArgs e)
        {
            string src = @"C:\Users\Peeko\Desktop\Code\Compi\go.go";
            string file = File.ReadAllText(src);
            txb_Texto.Text = file;
            string text = txb_Texto.Text;
            tablaResultados.Rows.Clear();
            TablaErrores.Rows.Clear();

            var lexico = new Lexico();
            lexico.cadena = text;
            lexico.resultsTable = tablaResultados;
            lexico.analizarLexico();
        }

        private void MetroBtnSintactico_Click(object sender, EventArgs e)
        {
            listaNodos = Lexico.nodos;
            var sintaxis = new Sintactico(listaNodos);
            sintaxis.Errores = TablaErrores;
            sintaxis.analizador();
        }
    }



}
