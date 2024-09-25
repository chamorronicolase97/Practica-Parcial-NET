namespace Chamorro.Escritorio
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos f = new frmAlumnos();
            f.ShowDialog();
        }
    }
}