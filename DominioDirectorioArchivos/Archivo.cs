using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominioDirectorioArchivos
{
    public class Archivo
    {
        public string Nombre { get; set; }

        public ICollection<AccesoDirecto> AccesosDirectos { get; }

        public Archivo()
        {
            this.AccesosDirectos = new List<AccesoDirecto>();
        }

        public void CrearAccesoDirecto(AccesoDirecto accesoDirecto)
        {
            if (!string.IsNullOrWhiteSpace(accesoDirecto.Nombre))
            {
                if (!AccesosDirectos.Contains(accesoDirecto))
                {
                    accesoDirecto.Fuente = this;
                    AccesosDirectos.Add(accesoDirecto);
                }
            }
        }

        public override bool Equals(object obj)
        {
            bool equals = false;

            if (obj != null && obj.GetType() != this.GetType())
            {
                Archivo archivo = (Archivo)obj;
                // Otra opcion de casteo: Archivo archivo2 = obj as Archivo;
                equals = this.Nombre.Equals(archivo.Nombre);
            }

            return equals;
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}
