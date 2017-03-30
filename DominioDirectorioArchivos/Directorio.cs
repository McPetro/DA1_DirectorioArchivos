using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioDirectorioArchivos
{
    public class Directorio
    {
        public List<Archivo> Archivos { get; }

        public Directorio()
        {
            this.Archivos = new List<Archivo>();
        }

        public void AgregarArchivo(Archivo archivo)
        {
            if (!string.IsNullOrWhiteSpace(archivo.Nombre) && !this.Archivos.Contains(archivo))
            {
                this.Archivos.Add(archivo);
            }
        }

        public Archivo ObtenerArchivo(string nombreArchivo)
        {
            return Archivos.Find(archivo => archivo.Nombre.Equals(nombreArchivo));
        }
    }
}
