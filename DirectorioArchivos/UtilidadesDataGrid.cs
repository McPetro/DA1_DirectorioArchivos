using DominioDirectorioArchivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectorioArchivos
{
    internal class UtilidadesDataGrid
    {
        internal static void AgregarColumna(DataGridView dataGrid, string property, string cabezal)
        {
            DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();

            columna.DataPropertyName = property;
            columna.HeaderText = cabezal;
            columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGrid.Columns.Add(columna);
        }

        internal static void SetearEstructuraBase(DataGridView dataGrid)
        {
            dataGrid.AutoGenerateColumns = false;
            dataGrid.AllowUserToResizeRows = false;
            dataGrid.MultiSelect = false;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGrid.Columns.Clear();

            dataGrid.RowHeadersVisible = false;
        }

        internal static object ObtenerObjetoEnPosicion(DataGridView dataGrid, int posicion)
        {
            return posicion >= 0 ? dataGrid.Rows[posicion].Cells[0].Value : null;
        }

        internal static void Actualizar(DataGridView dataGrid)
        {
            dataGrid.Update();
            dataGrid.Refresh();
        }
    }
}
