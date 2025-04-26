using System;

namespace minecraft.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int JugadorId { get; set; }
        public int BloqueId { get; set; }
        public int Cantidad { get; set; }
        public string NombreJugador { get; set; }  // Para mostrar en reportes
        public string NombreBloque { get; set; }
        public string Rareza { get; set; }// Para mostrar en reportes

        public override string ToString()
        {
            return $"ID: {Id}, Jugador: {NombreJugador}, Bloque: {NombreBloque}, Cantidad: {Cantidad}";
        }
    }
}