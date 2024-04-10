using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    internal class BLAgenda
    {
        public BEEstudiantes SeleccionarPersona(int codigo)
        {
            var bePersona = new BEEstudiantes();
            try
            {
                var dalPersona = new DAL.dalEstudiantes();
                var cPersona = dalPersona.seleccionarPersona(codigo);

                bePersona.codigo = cPersona.codigo;
                bePersona.nombre = cPersona.nombre;
                bePersona.apellidos = cPersona.apellidos;
                bePersona.direccion = cPersona.direccion;

                foreach (var tel in cPersona.telefonos)
                {
                    var btel = new BETelefono();
                    btel.codTelefono = tel.codTelefono;
                    btel.nroTelefono = tel.nroTelefono;
                    bePersona.telefonos.Add(btel);
                }
                return bePersona;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
