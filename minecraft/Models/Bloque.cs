using System;

namespace minecraft.Models
{
    public class Bloque
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public string Rareza { get; set; }
        public string Imagen { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Tipo: {Tipo}, Rareza: {Rareza}";
        }
    }
}