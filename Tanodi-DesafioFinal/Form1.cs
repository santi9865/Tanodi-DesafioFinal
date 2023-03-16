using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tanodi_DesafioFinal.Modelo;

namespace Tanodi_DesafioFinal
{
    public partial class frmCotipro : Form
    {
        public frmCotipro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Camisa camisa = new Camisa(true, TipoManga.Corta, true, 100, 1);

        }

    }
}
