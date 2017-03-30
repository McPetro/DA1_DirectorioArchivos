using System.Windows.Forms;
using DominioDirectorioArchivos;

namespace DirectorioArchivos
{
    public partial class VentanaPrincipal : Form
    {
        private Directorio directorioActual;
        public VentanaPrincipal()
        {
            directorioActual = new Directorio();
            InitializeComponent();
            this.CargarUserControlsArchivo(); 


        }

        private void CargarUserControlsArchivo() {

            this.panelPrincipal.Controls.Clear();
            this.panelPrincipal.Controls.Add(new AgregarArchivo(this.panelPrincipal, directorioActual));
        }

         
    }
}
