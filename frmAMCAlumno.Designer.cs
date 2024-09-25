namespace Chamorro.Escritorio
{
    partial class frmAMCAlumno
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
            txtNombre = new TextBox();
            label1 = new Label();
            dtpFecNacimiento = new DateTimePicker();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtDNI = new TextBox();
            label4 = new Label();
            txtNota = new TextBox();
            label5 = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(145, 35);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(224, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 38);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre y Apellido";
            // 
            // dtpFecNacimiento
            // 
            dtpFecNacimiento.Format = DateTimePickerFormat.Short;
            dtpFecNacimiento.Location = new Point(145, 197);
            dtpFecNacimiento.Name = "dtpFecNacimiento";
            dtpFecNacimiento.Size = new Size(150, 23);
            dtpFecNacimiento.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 120);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(145, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 78);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 6;
            label3.Text = "DNI";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(145, 75);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(150, 23);
            txtDNI.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 160);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 8;
            label4.Text = "Nota Promedio";
            // 
            // txtNota
            // 
            txtNota.Location = new Point(145, 157);
            txtNota.Name = "txtNota";
            txtNota.RightToLeft = RightToLeft.Yes;
            txtNota.Size = new Size(53, 23);
            txtNota.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 203);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 9;
            label5.Text = "Fecha Nacimiento";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(210, 258);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 10;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(294, 258);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 11;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAMCAlumno
            // 
            AcceptButton = btnAceptar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancelar;
            ClientSize = new Size(381, 293);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtNota);
            Controls.Add(label3);
            Controls.Add(txtDNI);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(dtpFecNacimiento);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Name = "frmAMCAlumno";
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private DateTimePicker dtpFecNacimiento;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtDNI;
        private Label label4;
        private TextBox txtNota;
        private Label label5;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}