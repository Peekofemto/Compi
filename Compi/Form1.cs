using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compi
{
    public partial class FormaPrincipal : Form
    {
        public FormaPrincipal()
        {
            InitializeComponent();
        }


        private void btnCompilar_Click(object sender, EventArgs e)
        {

            string text = txb_Texto.Text;
            tablaResultados.Rows.Clear();
            Lexico clase_lexico = new Lexico();
            clase_lexico.cadena = text;
            clase_lexico.resultsTable = tablaResultados;
            clase_lexico.analizadorlexico();


        }

    }



}
