using System;

namespace minecraft.Models
{
    public class Jugador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public DateTime FechaCreacion { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Nivel: {Nivel}, Creado: {FechaCreacion.ToShortDateString()}";
        }
    }
}