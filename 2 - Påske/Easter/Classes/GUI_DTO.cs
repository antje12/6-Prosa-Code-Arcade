using System;

namespace Easter.Classes
{
    public class DTO
    {
        public int ballX { get; set; }
        public int ballY { get; set; }

        public int xStartPlayer1 { get; set; }
        public int xEndPlayer1 { get; set; }

        public int yStartPlayer1 { get; set; }
        public int yEndPlayer1 { get; set; }

        public int xStartPlayer2 { get; set; }
        public int xEndPlayer2 { get; set; }

        public int yStartPlayer2 { get; set; }
        public int yEndPlayer2 { get; set; }

        public int player1Score { get; set; }
        public int player2Score { get; set; }
    }
}