﻿using SQLite;

namespace TareasApp.Models
{
    public class Tarea
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }
    }
}

