using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryObraCatala
{
    public partial class frmReservas : Form
    {
        public frmReservas()
        {
            InitializeComponent();
            cbLocal.SelectedIndexChanged += cbLocal_SelectedIndexChanged;
        }

        
        private void frmReservas_Load(object sender, EventArgs e)
        {
            

        }

        private void tblAsientosAzul_Paint(object sender, PaintEventArgs e)
        {
           


        }

        private void tblAsientosVerde_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            frmDatos frmDatos = new frmDatos();
            frmDatos.Show();
        }

        private void cbLocal_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            tblAsientosAzul.Controls.Clear();
            tblAsientosVerde.Controls.Clear();
            tblAsientosAzul.RowStyles.Clear();
            tblAsientosVerde.RowStyles.Clear();
            tblAsientosAzul.ColumnStyles.Clear();
            tblAsientosVerde.ColumnStyles.Clear();

            tblAsientosAzul.RowCount = 0;
            tblAsientosVerde.RowCount = 0;
            tblAsientosAzul.ColumnCount = 0;
            tblAsientosVerde.ColumnCount = 0;

            int LocalSeleccionado = Convert.ToInt32(cbLocal.SelectedItem);

            
        }
    }
}
    

