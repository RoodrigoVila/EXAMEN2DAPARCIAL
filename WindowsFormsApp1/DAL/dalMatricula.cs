using comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalMatricula
    {
        public CMatricula seleccionarMatricula(int ID_M)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new CMatricula();
                var pMatricula = bd.MATRICULA.First(s => s.id_matricula == ID_M);
                per.idMatricula = pMatricula.id_matricula;
                per.idEstudiante = pMatricula.id_estudiante;
                per.nivel = pMatricula.nivel;
                per.monto_m = pMatricula.monto_matricula;
                per.fecha_m = pMatricula.fecha_m;
                return per;
            }
        }

        public void registrarMatricula(CMatricula pMatricula)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new MATRICULA();
                per.id_matricula = pMatricula.idMatricula;
                per.id_estudiante = pMatricula.idEstudiante;
                per.nivel = pMatricula.nivel;
                per.monto_matricula = pMatricula.monto_m;
                per.fecha_m = pMatricula.fecha_m;
                bd.MATRICULA.Add(per);
                bd.SaveChanges();
            }
        }

        public void actualizarMatricula(CMatricula pMatricula)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = bd.MATRICULA.First(s => s.id_matricula == pMatricula.idMatricula);
                per.id_estudiante = pMatricula.idEstudiante;
                per.nivel = pMatricula.nivel;
                per.monto_matricula = pMatricula.monto_m;
                per.fecha_m = pMatricula.fecha_m;
                bd.SaveChanges();
            }
        }

        public void eliminarMatricula(int ID_MATRICULA)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = bd.MATRICULA.First(s => s.id_matricula == ID_MATRICULA);
                bd.MATRICULA.Remove(per);
                bd.SaveChanges();
            }
        }
    }
}
