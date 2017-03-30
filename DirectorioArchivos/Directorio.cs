using System.Windows.Forms;
using DominioDirectorioArchivos;

namespace DirectorioArchivos
{
    public partial class VentanaPrincipal : Form
    {
        private Directorio directorioActual;
        public VentanaPrincipal()
        {
            InitializeComponent();
            this.CargarUserControlsArchivo();
            directorioActual = new Directorio();


        }

        private void CargarUserControlsArchivo() {

            this.panelPrincipal.Controls.Clear();
            this.panelPrincipal.Controls.Add(new AgregarArchivo());
        }

         
    }
}
