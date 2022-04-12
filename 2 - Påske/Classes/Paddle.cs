namespace Easter.Classes
{
    public class Paddle
    {
        public int xStart;
        public int xEnd;

        public int yStart;
        public int yEnd;

        public Paddle(int playerNumber)
        {
            if (playerNumber == 1)
            {
                xStart = 200;
                xEnd = 300;

                yStart = 490;
                yEnd = 490;
            }
            else if (playerNumber == 2)
            {
                xStart = 200;
                xEnd = 300;

                yStart = 10;
                yEnd = 10;
            }
        }

        public void reset()
        {
            xStart = 200;
            xEnd = 300;
        }

        public void moveRight(int speed)
        {
            if (xEnd < Game.xEnd)
            {
                xStart += speed;
                xEnd += speed;
            }
        }

        public void moveLeft(int speed)
        {
            if (Game.xStart < xStart)
            {
                xStart -= speed;
                xEnd -= speed;
            }
        }
    }
}