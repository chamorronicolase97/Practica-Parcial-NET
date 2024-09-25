using Chamorro.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chamorro.Escritorio
{
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            CargaGrilla();
        }

        private void CargaGrilla()
        {
            dgvDatos.DataSource = Alumno.RecuperarTodos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAMCAlumno f = new frmAMCAlumno();
            f.ShowDialog();

            if (f.DialogResult == DialogResult.OK) CargaGrilla();
        }
    }
}
