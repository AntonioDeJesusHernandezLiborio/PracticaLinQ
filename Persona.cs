using System;
using System.Collections.Generic;
using System.Text;

namespace Dummy
{
    public class Persona
    {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Cuidad { get; set; }
            public string Estado { get; set; }
            public int Edad { get; set; }
            public Universidad  Universidad  { get; set; }
            public List<Habilidad> Habilidades { get; set; }

    }
}
