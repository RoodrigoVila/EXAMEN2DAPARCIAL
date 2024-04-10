using comun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class dalPension
    {
        public CPension seleccionarPension(int ID)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new CPension();
                var pPension = bd.PENSION.First(s => s.id_pensiones == ID);
                per.id_estudiante = pPension.id_estudiante;
                per.n_pension = pPension.n_pension;
                per.monto = pPension.monto;
                per.fecha_p = pPension.fecha_p;
                per.mora = pPension.mora;
                return per;
            }
        }

        public void insertarPension(CPension pPension)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = new PENSION();
                per.id_estudiante = pPension.id_estudiante;
                per.n_pension = pPension.n_pension;
                per.monto = pPension.monto;
                per.fecha_p = pPension.fecha_p;
                per.mora = pPension.mora;
                bd.PENSION.Add(per);
                bd.SaveChanges();
            }
        }

        public void actualizarPension(CPension pPension)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = bd.PENSION.First(s => s.id_pensiones == pPension.id_pensiones);
                per.id_estudiante = pPension.id_estudiante;
                per.n_pension = pPension.n_pension;
                per.monto = pPension.monto;
                per.fecha_p = pPension.fecha_p;
                per.mora = pPension.mora;
                bd.SaveChanges();
            }
        }

        public void eliminarPension(int ID_PENSIONES)
        {
            using (var bd = new BD_MATRICULAEntities())
            {
                var per = bd.PENSION.First(s => s.id_pensiones == ID_PENSIONES);
                bd.PENSION.Remove(per);
                bd.SaveChanges();
            }
        }
    }
}
