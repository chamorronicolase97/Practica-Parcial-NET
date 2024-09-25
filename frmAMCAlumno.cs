using Chamorro.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlumnoNegocio = Chamorro.Negocio.Alumno;

namespace Chamorro.Escritorio
{
    public partial class frmAMCAlumno : Form
    {

        public frmAMCAlumno()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            Alumno alumno = new Alumno();
            alumno.ApellidoNombre = txtNombre.Text;
            alumno.Email = txtEmail.Text;
            alumno.FechaNacimiento = dtpFecNacimiento.Value;
            alumno.DNI = txtDNI.Text;
            alumno.NotaPromedio = Convert.ToDecimal(txtNota.Text);

            AlumnoNegocio.Agregar(alumno);
            MessageBox.Show("Operación exitosa", "Alumno", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;

            Close();
        }

        private bool ValidarCampos()
        {
            AlumnoNegocio.NombreValido(txtNombre.Text);
            AlumnoNegocio.EsMailValido(txtEmail.Text);
            AlumnoNegocio.NotaValida(txtNota.Text);
            AlumnoNegocio.FechaValida(dtpFecNacimiento.Value);

            return true;
        }

    }
}
