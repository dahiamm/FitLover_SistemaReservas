
namespace Sistema_Reservas_Listas_
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.btnVerReserva = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHacerReserva = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerReserva
            // 
            this.btnVerReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(245)))), ((int)(((byte)(28)))));
            this.btnVerReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerReserva.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnVerReserva.Location = new System.Drawing.Point(438, 369);
            this.btnVerReserva.Name = "btnVerReserva";
            this.btnVerReserva.Size = new System.Drawing.Size(177, 36);
            this.btnVerReserva.TabIndex = 1;
            this.btnVerReserva.Text = "Ver reservas";
            this.btnVerReserva.UseVisualStyleBackColor = false;
            this.btnVerReserva.Click += new System.EventHandler(this.btnVerReserva_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(160, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 351);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnHacerReserva
            // 
            this.btnHacerReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(245)))), ((int)(((byte)(28)))));
            this.btnHacerReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHacerReserva.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHacerReserva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.btnHacerReserva.Location = new System.Drawing.Point(198, 369);
            this.btnHacerReserva.Name = "btnHacerReserva";
            this.btnHacerReserva.Size = new System.Drawing.Size(177, 36);
            this.btnHacerReserva.TabIndex = 0;
            this.btnHacerReserva.Text = "Hacer una reserva";
            this.btnHacerReserva.UseVisualStyleBackColor = false;
            this.btnHacerReserva.Click += new System.EventHandler(this.btnHacerReserva_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(53)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVerReserva);
            this.Controls.Add(this.btnHacerReserva);
            this.Name = "FormInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnVerReserva;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHacerReserva;
    }
}