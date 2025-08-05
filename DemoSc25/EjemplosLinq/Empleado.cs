using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosLinq
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public decimal SalarioMensual { get; set; }
        public int AntiguedadAnios { get; set; }

        // Campos agregados por procesos
        public decimal SalarioAnual { get; set; }
        public int DiasVacaciones { get; set; }
        public string ClasificacionSalarial { get; set; }
        public decimal Bonificacion { get; set; }
        public int EdadEstimada { get; set; }
        public DateTime FechaAscenso { get; set; }
        public bool RiesgoRotacion { get; set; }
        public int HorasTrabajadasAnuales { get; set; }
        public string PlanSalud { get; set; }
        public decimal RetencionIRPF { get; set; }
        public DateTime FechaRevisionContrato { get; set; }
    }
}
