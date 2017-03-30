using System.Windows.Forms;

namespace DirectorioArchivos
{
    public partial class AgregarArchivo : UserControl
    {
        private UtilidadesDataGrid datagridmodel ; 
        public AgregarArchivo()
        {
            InitializeComponent();
            datagridmodel = new UtilidadesDataGrid();
        }
    }
}
