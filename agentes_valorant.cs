using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class agentes_valorant
    {
       public int id {get;set;}

        public string nombre_agente { get; set; }

        public string tipo_agente { get; set; }

        public string nacionalidad { get; set; }

        public string fecha_lanzamiento { get; set; }

        public agentes_valorant(int id,string nombre_agente,string tipo_agente, string nacionalidad,string fecha_lanzamiento)
        {
            this.id = id;
            this.nombre_agente = nombre_agente;
            this.tipo_agente = tipo_agente;
            this.nacionalidad = nacionalidad;
            this.fecha_lanzamiento = fecha_lanzamiento;
        }
    }
}
