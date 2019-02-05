using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TaskKitLTA.BD
{
    [Table("pendientes")]
    public class PendientesBD
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(20)]
        public String Titulo { get; set; }

        [MaxLength(140)]
        public String Descripcion { get; set; }

        public DateTime Fecha { get; set; }
    }
}
