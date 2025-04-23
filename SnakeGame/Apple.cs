namespace SnakeGame
{
    internal class Apple
    {
        public Point Position { get; private set; }
        private Random _random = new Random();

        public Apple(int mapWidth, int mapHeight, List<Point> snakeBody)
        {
            GenerateNewPosition(mapWidth, mapHeight, snakeBody);
        }

        public void GenerateNewPosition(int mapWidth, int mapHeight, List<Point> snakeBody)
        {
            do
            {
                Position = new Point(
                    _random.Next(1, mapWidth),      
                    _random.Next(1, mapHeight)
                );
            }
            while (snakeBody.Any(p => p.X == Position.X && p.Y == Position.Y));
        }
    }
}
