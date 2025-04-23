namespace SnakeGame
{
    public class Game
    {
        private Snake _snake;
        private Apple _apple;
        private bool _isGameRunning;
        private readonly int _mapWidth = 20;
        private readonly int _mapHeight = 10;

        public Game()
        {
            _snake = new Snake(5, 5);
            _apple = new Apple(_mapWidth, _mapHeight, _snake.Body);
            _isGameRunning = true;
        }

        public void Start()
        {
            while (_isGameRunning)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey(true).Key;
                    _snake.ChangeDirection(key);
                }

                bool moved = _snake.Move(_mapWidth, _mapHeight);
                bool collisioned = _snake.Collisions();

                if(collisioned)
                {
                    _isGameRunning = false;
                    Console.Clear();
                    Console.WriteLine("Game Over! You hit the yourself.");
                    return;
                }

                if (!moved)
                {
                    _isGameRunning = false;
                    Console.Clear();
                    Console.WriteLine("Game Over! You hit the wall.");
                    return;
                }

                if(_snake.CheckApple(_apple.Position))
                {
                    _snake.Grow();
                    _apple.GenerateNewPosition(_mapWidth, _mapHeight, _snake.Body);
                }

                Render();
                Thread.Sleep(250);
            }
        }

        public void Render()
        {
            Console.Clear();
            DrawBoard();

            foreach (var point in _snake.Body)
            {
                if(point.X >= 0 && point.X < _mapWidth && point.Y >= 0 && point.Y < _mapHeight)
                {
                    Console.SetCursorPosition(point.X, point.Y);
                    Console.Write("O");
                }
            }
            Console.SetCursorPosition(_apple.Position.X, _apple.Position.Y);
            Console.Write("@");
        }

        private void DrawBoard()
        {
            // Upper board
            for (int x = 0; x < _mapWidth; x++)
            {
                Console.SetCursorPosition(x, 0);
                Console.Write("#");
            }

            // Down board
            for(int x = 0; x <= _mapWidth; x++)
            {
                Console.SetCursorPosition(x, _mapHeight);
                Console.Write("#");
            }

            // Left board
            for (int y = 1; y <= _mapHeight; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.Write("#");
                Console.SetCursorPosition(_mapWidth + 1, y);
                Console.Write("#");
            }
        }
    }
}
