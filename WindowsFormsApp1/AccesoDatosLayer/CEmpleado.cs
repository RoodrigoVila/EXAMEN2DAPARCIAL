using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comun
{
    public class CEmpleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public decimal sueldob { get; set; }
        public string categoria { get; set; }

        public override string ToString()
        {
            return string.Format("Empleado (id={0} nombre={1}, apellidos={2}, sueldob={3}, categoria={4})",
                                  id, nombre, apellidos, sueldob, categoria);
        }
    }
}
