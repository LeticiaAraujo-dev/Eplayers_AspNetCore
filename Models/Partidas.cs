using System;

namespace Eplayers_AspNetCore.Models
{
    public class Partidas
    {
        public int IdPartida { get; set; }
        public int IdJogador1 { get; set; }
        public int IdJogador2 { get; set; }
        public DateTime HorarioIncio { get; set; }
        public DateTime HorarioTermino { get; set; }


    }
}