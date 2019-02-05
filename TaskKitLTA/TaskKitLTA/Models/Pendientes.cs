using System;
using System.Collections.Generic;
using System.Text;

namespace TaskKitLTA.Models
{
    public class Pendientes
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
    }
}
