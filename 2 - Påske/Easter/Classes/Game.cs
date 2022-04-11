using System.Text.Json;
using Microsoft.AspNetCore.SignalR;
using Timer = System.Timers.Timer;

namespace Easter.Classes
{
    public class Game
    {
        // field
        public static int xStart;
        public static int xEnd;
        public static int yStart;
        public static int yEnd;

        // scores
        public int p1Score;
        public int p2Score;

        // objects
        public Paddle p1;
        public Paddle p2;
        public Ball ball;

        // timer stuff
        private Timer gameTime;
        private int gameTimeInterval;

        public string player1;
        public string player2;
        private IHubCallerClients _clients;

        public Game()
        {
            gameTimeInterval = 30;
            gameTime = new Timer();
            gameTime.Interval = gameTimeInterval;
            gameTime.Elapsed += gameTime_Tick;

            p1 = new Paddle(1);
            p2 = new Paddle(2);
            ball = new Ball();

            xStart = 0;
            xEnd = 500;
            yStart = 0;
            yEnd = 500;
        }

        public void startGame(IHubCallerClients clients)
        {
            _clients = clients;

            // start timer
            gameTime.Enabled = true;

            // reset
            p1Score = 0;
            p2Score = 0;
            ball.reset();
            p1.reset();
            p2.reset();
        }

        public void endGame()
        {
            // stop timer
            gameTime.Enabled = false;
        }

        private void gameTime_Tick(object sender, EventArgs e)
        {
            ball.move();
            gameAreaCollisions();
            paddleCollisions();
            updateClients();
        }

        private void gameAreaCollisions()
        {
            if (ball.x >= xEnd || ball.x <= xStart)
            {
                ball.xTurn();
            }
            else if (ball.y >= yEnd)
            {
                p2Score++;
                ball.reset();
            }
            else if (ball.y <= yStart)
            {
                p1Score++;
                ball.reset();
            }
        }

        private void paddleCollisions()
        {
            if (ball.y == p1.yStart && p1.xStart <= ball.x && ball.x <= p1.xEnd)
            {
                double middle = ((p1.xEnd - p1.xStart) / 2) + p1.xStart;
                if (ball.x == middle)
                {
                    ball.yTurn();
                }
                else if (ball.x < middle)
                {
                    ball.randomizeLeftTurn();
                }
                else
                {
                    ball.randomizeRightTurn();
                }

                ball.speedUp();
            }
            else if (ball.y == p2.yStart && p2.xStart <= ball.x && ball.x <= p2.xEnd)
            {
                double middle = ((p2.xEnd - p2.xStart) / 2) + p2.xStart;
                if (ball.x == middle)
                {
                    ball.yTurn();
                }
                else if (ball.x < middle)
                {
                    ball.randomizeLeftTurn();
                }
                else
                {
                    ball.randomizeRightTurn();
                }

                ball.speedUp();
            }
        }

        private void updateClients()
        {
            var dto = new DTO();

            dto.ballX = ball.x;
            dto.ballY = ball.y;

            dto.xStartPlayer1 = p1.xStart;
            dto.xEndPlayer1 = p1.xEnd;
            dto.yStartPlayer1 = p1.yStart;
            dto.yEndPlayer1 = p1.yEnd;

            dto.xStartPlayer2 = p2.xStart;
            dto.xEndPlayer2 = p2.xEnd;
            dto.yStartPlayer2 = p2.yStart;
            dto.yEndPlayer2 = p2.yEnd;

            dto.player1Score = p1Score;
            dto.player2Score = p2Score;

            var str = JsonSerializer.Serialize(dto);
            _clients.All.SendAsync("move", str);
        }
    }
}