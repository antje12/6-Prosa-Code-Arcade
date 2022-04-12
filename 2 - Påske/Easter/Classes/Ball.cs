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

        public void yTurn(double difference)
        {
            ySpeed = -ySpeed;

            if (difference < 0)
            {
                var tweak = Map(difference, -50, 0, -4, 0);
                xSpeed = (int) tweak;
            }
            else if (0 < difference)
            {
                var tweak = Map(difference, 0, 50, 0, 4);
                xSpeed = (int) tweak;
            }
        }

        private static double Map (double value, double fromSource, double toSource, double fromTarget, double toTarget)
        {
            return (value - fromSource) / (toSource - fromSource) * (toTarget - fromTarget) + fromTarget;
        }
    }
}