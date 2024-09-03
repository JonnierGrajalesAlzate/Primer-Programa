using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjRecopilacionDeDatos
{
    internal class Persona
    {
        private string pcNombre;
        private string pcApellidos;
        private long pnIdentificacion;
        private string pcCorreo;

        private string pcEmpresa;
        private long pnNit;
        private string pcTelefono;

        public Persona(string tcNom, string tcApe, long tnId, string tcCorreo, string tcEmpresa, long tnNit, string tcTel) { 
          pcNombre = tcNom;
          pcApellidos = tcApe;
          pnIdentificacion = tnId;
          pcCorreo = tcCorreo;
          pcEmpresa = tcEmpresa;
          pnNit = tnNit;
          pcTelefono = tcTel;
        }

        public string getNombre()
        {
            return pcNombre;
        }
        public string getApellidos() {
            return pcApellidos;
        }
        public long getId()
        {
            return pnIdentificacion;
        }
        public string getCorreo()
        {
            return pcCorreo;
        }
        public string getEmpresa()
        {
            return pcEmpresa;
        }
        public long getNit() { 
           return pnNit;
        }
        public string getTelefono() {
            return pcTelefono;
        }

    }
}
