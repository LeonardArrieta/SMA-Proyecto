using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class CitaOdontologicas 
    {
        public double IdCita { get; set; }
        public double IdPaciente { get; set; }
        public string NombreMedico { get; set; }
        public string TipoDeServicio { get; set; }
        public DateTime FechaCita{ get; set; }
        public double IdOdontologo { get; set; }
        public string Motivo { get; set; }

    }
}
