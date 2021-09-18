using System;
using System.Collections.Generic;
using System.Text;

namespace Dummy
{
    public class Universidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public List<Materia> Materias { get; set; }
    }
}
