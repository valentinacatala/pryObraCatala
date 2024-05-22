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

            cbLocal.Items.Add("Quenaken");
            cbLocal.Items.Add("Onas");
            cbLocal.Items.Add("Tobas");

            // Suscribir el evento SelectionChanged del ComboBox
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

            int opcionSeleccionada = cbLocal.SelectedIndex;

            switch (opcionSeleccionada)
            {
                case 0:
                    tblAsientosAzul.RowCount = 20;
                    tblAsientosAzul.RowCount = 20;
                    tblAsientosAzul.ColumnCount = 5;
                    tblAsientosVerde.ColumnCount=5;

                    tblAsientosAzul.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
                    tblAsientosAzul.RowStyles.Add(new RowStyle(SizeType.Percent, 20));
                    tblAsientosAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    tblAsientosAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                    tblAsientosVerde.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosVerde.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosVerde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    tblAsientosVerde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    break;

                case 1:
                    tblAsientosAzul.RowCount = 40;
                    tblAsientosAzul.RowCount = 20;
                    tblAsientosAzul.ColumnCount = 5;
                    tblAsientosVerde.ColumnCount = 5;

                    tblAsientosAzul.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosAzul.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    tblAsientosAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                    tblAsientosVerde.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosVerde.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosVerde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    tblAsientosVerde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    break;

                case 2:
                    tblAsientosAzul.RowCount = 20;
                    tblAsientosAzul.RowCount = 20;
                    tblAsientosAzul.ColumnCount = 5;
                    tblAsientosVerde.ColumnCount = 5;

                    tblAsientosAzul.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosAzul.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    tblAsientosAzul.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                    tblAsientosVerde.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosVerde.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                    tblAsientosVerde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    tblAsientosVerde.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                    break;
            }


        }
    }
}
    

