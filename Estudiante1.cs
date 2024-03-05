using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_de_datos_de_un_estudiante
{
    public class Estudiante1 : Persona1
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string Curso { get; set; }
        public string Seccion { get; set; }
        public string AreaTecnica { get; set; }

        public string MaestroTitular { get; set; }
    }
}
