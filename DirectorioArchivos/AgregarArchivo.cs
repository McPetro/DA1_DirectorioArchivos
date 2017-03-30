using DominioDirectorioArchivos;
using System.Windows.Forms;

namespace DirectorioArchivos
{
    public partial class AgregarArchivo : UserControl
    {
        private Panel panel;
        private Archivo archivoSeleccionado;
        private Directorio directorio;

        public AgregarArchivo(Panel panel, Directorio directorio)
        {
            InitializeComponent();
            this.panel = panel;
            this.directorio = directorio;
            CargarColumnas();
            CargarArchivos();
        }

        private void buttonArchivo_Click(object sender, System.EventArgs e)
        {
            bool nombreCorrecto = !string.IsNullOrWhiteSpace(txtNombre.Text);

            if (nombreCorrecto)
            {
                directorio.AgregarArchivo(new Archivo
                {
                    Nombre = txtNombre.Text
                });

                CargarArchivos();
                this.txtNombre.Text = "";
            }
            else
            {
                MessageBox.Show("Nombre incorrecto", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void CargarColumnas()
        {
            UtilidadesDataGrid.SetearEstructuraBase(dataGrid);
            UtilidadesDataGrid.AgregarColumna(dataGrid, "Nombre", "Nombre");
            UtilidadesDataGrid.AgregarColumna(dataGrid, "Cantidad Links", "Cantidad Links");
        }

        private void CargarArchivos()
        {
            dataGrid.Rows.Clear();

            foreach (Archivo archivo in directorio.Archivos)
            {
                object[] datosFila = { archivo.Nombre, archivo.AccesosDirectos.Count };
                dataGrid.Rows.Add(datosFila);
            }

            SeleccionarArchivo(0);
            UtilidadesDataGrid.Actualizar(dataGrid);
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int posicion = e.RowIndex;
            SeleccionarArchivo(posicion);
        }

        private void SeleccionarArchivo(int posicion)
        {
            if (directorio.Archivos.Count > 0 && posicion >= 0)
            {
                string nombreArchivo = (string)UtilidadesDataGrid.ObtenerObjetoEnPosicion(dataGrid, posicion);
                archivoSeleccionado = directorio.ObtenerArchivo(nombreArchivo);
            }
            else
            {
                archivoSeleccionado = null;
            }
        }

    }
}
