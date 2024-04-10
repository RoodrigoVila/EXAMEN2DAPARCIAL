using AccesoDatosLayer.EmpresaDBDataSetTableAdapters;
using System;
using System.Linq;
using comun;

namespace AccesoDatosLayer
{
    public class dalEmpleado
    {
        private TrabajadoresTableAdapter _trabajadoresTableAdapter;

        public dalEmpleado()
        {
            _trabajadoresTableAdapter = new TrabajadoresTableAdapter();
        }

        public CEmpleado SeleccionarEmpleado(int id)
        {
            var empleado = _trabajadoresTableAdapter.GetData().FirstOrDefault(s => s.id == id);

            if (empleado == null)
            {
                return null;
            }

            return new CEmpleado
            {
                id = empleado.id,
                nombre = empleado.nombre,
                apellidos = empleado.apellidos,
                sueldob = empleado.sueldob,
                categoria = empleado.categoria
            };
        }

        public void InsertarEmpleado(CEmpleado pEmpleado)
        {
            var nuevoEmpleado = _trabajadoresTableAdapter.GetData().NewTrabajadoresRow();
            nuevoEmpleado.nombre = pEmpleado.nombre;
            nuevoEmpleado.apellidos = pEmpleado.apellidos;
            nuevoEmpleado.sueldob = pEmpleado.sueldob;
            nuevoEmpleado.categoria = pEmpleado.categoria;
            _trabajadoresTableAdapter.GetData().AddTrabajadoresRow(nuevoEmpleado);
            _trabajadoresTableAdapter.Update(nuevoEmpleado);
        }

        public void ActualizarEmpleado(CEmpleado pEmpleado)
        {
            var empleado = _trabajadoresTableAdapter.GetData().First(s => s.id == pEmpleado.id);
            empleado.nombre = pEmpleado.nombre;
            empleado.apellidos = pEmpleado.apellidos;
            empleado.sueldob = pEmpleado.sueldob;
            empleado.categoria = pEmpleado.categoria;
            _trabajadoresTableAdapter.Update(empleado);
        }

        public void EliminarEmpleado(int ID_Empleado)
        {
            var empleado = _trabajadoresTableAdapter.GetData().First(s => s.id == ID_Empleado);
            _trabajadoresTableAdapter.Delete(empleado.id, empleado.nombre, empleado.apellidos, empleado.sueldob, empleado.categoria);
        }
    }
}
