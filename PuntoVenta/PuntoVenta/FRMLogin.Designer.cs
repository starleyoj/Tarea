namespace PuntoVenta
{
    partial class FRMLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TXTUsuario = new System.Windows.Forms.TextBox();
            this.TXTContrasenia = new System.Windows.Forms.TextBox();
            this.BTNAceptar = new System.Windows.Forms.Button();
            this.BTNCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contrasena:";
            // 
            // TXTUsuario
            // 
            this.TXTUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TXTUsuario.Location = new System.Drawing.Point(156, 31);
            this.TXTUsuario.Name = "TXTUsuario";
            this.TXTUsuario.Size = new System.Drawing.Size(166, 27);
            this.TXTUsuario.TabIndex = 2;
            // 
            // TXTContrasenia
            // 
            this.TXTContrasenia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.TXTContrasenia.Location = new System.Drawing.Point(156, 80);
            this.TXTContrasenia.Name = "TXTContrasenia";
            this.TXTContrasenia.PasswordChar = '*';
            this.TXTContrasenia.Size = new System.Drawing.Size(166, 27);
            this.TXTContrasenia.TabIndex = 3;
            this.TXTContrasenia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTContrasenia_KeyPress);
            // 
            // BTNAceptar
            // 
            this.BTNAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BTNAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNAceptar.Location = new System.Drawing.Point(41, 140);
            this.BTNAceptar.Name = "BTNAceptar";
            this.BTNAceptar.Size = new System.Drawing.Size(105, 39);
            this.BTNAceptar.TabIndex = 4;
            this.BTNAceptar.Text = "Aceptar";
            this.BTNAceptar.UseVisualStyleBackColor = false;
            this.BTNAceptar.Click += new System.EventHandler(this.BTNAceptar_Click);
            // 
            // BTNCancelar
            // 
            this.BTNCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BTNCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTNCancelar.Location = new System.Drawing.Point(224, 140);
            this.BTNCancelar.Name = "BTNCancelar";
            this.BTNCancelar.Size = new System.Drawing.Size(98, 39);
            this.BTNCancelar.TabIndex = 5;
            this.BTNCancelar.Text = "Cancelar";
            this.BTNCancelar.UseVisualStyleBackColor = false;
            this.BTNCancelar.Click += new System.EventHandler(this.BTNCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntoVenta.Properties.Resources.j0432560;
            this.pictureBox1.Location = new System.Drawing.Point(373, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FRMLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(533, 237);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BTNCancelar);
            this.Controls.Add(this.BTNAceptar);
            this.Controls.Add(this.TXTContrasenia);
            this.Controls.Add(this.TXTUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FRMLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seguridad (Autenticacion de usuario)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TXTUsuario;
        private System.Windows.Forms.TextBox TXTContrasenia;
        private System.Windows.Forms.Button BTNAceptar;
        private System.Windows.Forms.Button BTNCancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}