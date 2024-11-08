
namespace Sistema_Reservas_Listas_
{
    partial class FormReservar
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
            this.cboServicios = new System.Windows.Forms.ComboBox();
            this.dtFechaHora = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cboServicios
            // 
            this.cboServicios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.cboServicios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.cboServicios.FormattingEnabled = true;
            this.cboServicios.Location = new System.Drawing.Point(166, 85);
            this.cboServicios.Name = "cboServicios";
            this.cboServicios.Size = new System.Drawing.Size(263, 21);
            this.cboServicios.TabIndex = 6;
            this.cboServicios.Text = "Seleccione el servicio que desea";
            // 
            // dtFechaHora
            // 
            this.dtFechaHora.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.dtFechaHora.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dtFechaHora.Location = new System.Drawing.Point(166, 123);
            this.dtFechaHora.Name = "dtFechaHora";
            this.dtFechaHora.Size = new System.Drawing.Size(263, 20);
            this.dtFechaHora.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(23, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Fecha y hora:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tipo de servicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cliente:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(245)))), ((int)(((byte)(28)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Myanmar Text", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnAgregar.Location = new System.Drawing.Point(156, 197);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(154, 31);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar reserva";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.txtNombre.Location = new System.Drawing.Point(166, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(263, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.Text = "Ingrese su nombre";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtNombre);
            this.panel2.Controls.Add(this.btnAgregar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtFechaHora);
            this.panel2.Controls.Add(this.cboServicios);
            this.panel2.Location = new System.Drawing.Point(164, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(463, 249);
            this.panel2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Myanmar Text", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(245)))), ((int)(((byte)(28)))));
            this.label4.Location = new System.Drawing.Point(301, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 43);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nueva reserva";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Sistema_Reservas_Listas_.Properties.Resources.Green_White_Modern_Heart_Illustration_Fitness_and_Gym_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(-51, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FormReservar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Name = "FormReservar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Reservas";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboServicios;
        private System.Windows.Forms.DateTimePicker dtFechaHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

