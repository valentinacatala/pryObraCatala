namespace pryObraCatala
{
    partial class frmReservas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblLocal = new System.Windows.Forms.Label();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblAsientosAzul = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tblAsientosVerde = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocal.Location = new System.Drawing.Point(12, 17);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(97, 16);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Seleccione Local";
            // 
            // cbLocal
            // 
            this.cbLocal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Location = new System.Drawing.Point(115, 17);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(196, 21);
            this.cbLocal.TabIndex = 1;
            this.cbLocal.SelectedIndexChanged += new System.EventHandler(this.cbLocal_SelectedIndexChanged);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(352, 7);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(94, 38);
            this.btnReservar.TabIndex = 2;
            this.btnReservar.Text = "Reservar ";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(471, 7);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(88, 38);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.tblAsientosAzul);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.tblAsientosVerde);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(572, 396);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 39);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(569, 35);
            this.panel2.TabIndex = 2;
            // 
            // tblAsientosAzul
            // 
            this.tblAsientosAzul.ColumnCount = 2;
            this.tblAsientosAzul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosAzul.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosAzul.Location = new System.Drawing.Point(3, 48);
            this.tblAsientosAzul.Name = "tblAsientosAzul";
            this.tblAsientosAzul.RowCount = 2;
            this.tblAsientosAzul.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosAzul.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosAzul.Size = new System.Drawing.Size(569, 144);
            this.tblAsientosAzul.TabIndex = 3;
            this.tblAsientosAzul.Paint += new System.Windows.Forms.PaintEventHandler(this.tblAsientosVerde_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESCENARIO";
            // 
            // tblAsientosVerde
            // 
            this.tblAsientosVerde.ColumnCount = 2;
            this.tblAsientosVerde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosVerde.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosVerde.Location = new System.Drawing.Point(3, 239);
            this.tblAsientosVerde.Name = "tblAsientosVerde";
            this.tblAsientosVerde.RowCount = 2;
            this.tblAsientosVerde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosVerde.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblAsientosVerde.Size = new System.Drawing.Size(569, 157);
            this.tblAsientosVerde.TabIndex = 4;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 479);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.cbLocal);
            this.Controls.Add(this.lblLocal);
            this.Name = "frmReservas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserva de Ubicaciones";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tblAsientosAzul;
        private System.Windows.Forms.TableLayoutPanel tblAsientosVerde;
    }
}

