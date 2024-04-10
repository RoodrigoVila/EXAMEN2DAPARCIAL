using comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalEstudiantes
    {
        public CEstudiantes seleccionarEstudiante(int ID)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new CEstudiantes();
                var pEstudiante = bd.ESTUDIANTE.First(s => s.id_estudiante == ID);
                per.id = pEstudiante.id_estudiante;
                per.dni = pEstudiante.dni;
                per.nombres = pEstudiante.nombres;
                per.apellidos = pEstudiante.apellidos;
                per.telefono= pEstudiante.telefono;
                return per;
            }
        }

        public void insertarEstudiante(CEstudiantes pEstudiante)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new ESTUDIANTE();
                per.id_estudiante = pEstudiante.id;
                per.dni = pEstudiante.dni;
                per.nombres = pEstudiante.nombres;
                per.apellidos = pEstudiante.apellidos;
                per.telefono = pEstudiante.telefono;
                bd.ESTUDIANTE.Add(per);
                bd.SaveChanges();
            }
        }

        public void actualizarEstudiante(CEstudiantes pEstudiantes)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = bd.ESTUDIANTE.First(s => s.id_estudiante == pEstudiantes.id);
                per.dni = pEstudiantes.dni;
                per.nombres = pEstudiantes.nombres;
                per.apellidos = pEstudiantes.apellidos;
                per.telefono = pEstudiantes.telefono;
                bd.SaveChanges();
            }
        }

        public void eliminarEstudiante(int ID_ESTUDIANTE)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = bd.ESTUDIANTE.First(s => s.id_estudiante == ID_ESTUDIANTE);
                bd.ESTUDIANTE.Remove(per);
                bd.SaveChanges();
            }
        }
    }
}
