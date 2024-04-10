using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BEEstudiantes
    {
        public int id { get; set; }
        public string dni { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }

        public override string ToString()
        {
            return string.Format("Estudiante (id={0} dni={1}, nombres={2}, apellidos={3}, telefono={4})",
                                  id, dni, nombres, apellidos, telefono);
        }
    }
}
