namespace Easter.Classes
{
    public class Ball
    {
        private static Random r = new Random();

        public int x;
        public int y;

        public int xSpeed;
        public int ySpeed;

        public Ball()
        {
            x = 250;
            y = 250;

            xSpeed = 0;
            ySpeed = 1;
        }

        public void move()
        {
            x += xSpeed;
            y += ySpeed;
        }

        public void reset()
        {
            x = 250;
            y = 250;
            xSpeed = 0;
            ySpeed = 1;
        }

        public void speedUp()
        {
            if (ySpeed < 0)
            {
                ySpeed--;
            }
            else if (0 < ySpeed)
            {
                ySpeed++;
            }
        }

        public void xTurn()
        {
            xSpeed = -xSpeed;
        }

        public void yTurn()
        {
            ySpeed = -ySpeed;
        }

        public void randomizeLeftTurn()
        {
            yTurn();
            double t = r.Next(1, 4);
            xSpeed = (int) -t;
        }
        public void randomizeRightTurn()
        {
            yTurn();
            double t = r.Next(1, 4);
            xSpeed = (int) t;
        }
    }
}