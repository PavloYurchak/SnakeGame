namespace SnakeGame
{
    internal class Snake
    {
        public List<Point> Body { get; private set; }
        private Direction _direction;

        public Snake(int startX, int stractY)
        {
            Body = new List<Point> { new Point(startX, stractY) };
            _direction = Direction.Right; // Start moving to the right
        }

        public bool Move(int mapWidth, int mapHeight)
        {
            Point head = Body[0];
            Point newHead = head;

            switch (_direction)
            {
                case Direction.Up:
                    newHead = new Point(head.X, head.Y - 1);
                    break;
                case Direction.Down:
                    newHead = new Point(head.X, head.Y + 1);
                    break;
                case Direction.Left:
                    newHead = new Point(head.X - 1, head.Y);
                    break;
                case Direction.Right:
                    newHead = new Point(head.X + 1, head.Y);
                    break;
            }

            if (newHead.X < 1 || newHead.X >= mapWidth || newHead.Y < 1 || newHead.Y >= mapHeight)
                return false;

            Body.Insert(0, newHead); // Add new head to the front
            Body.RemoveAt(Body.Count - 1); // Remove the tail

            return true;
        }

        public bool CheckApple(Point applePosition)
        {
            Point head = Body[0];
            if(head.X == applePosition.X && head.Y == applePosition.Y)
                return true;
            return false;
        }

        public void Grow()
        {
            Point tail = Body[Body.Count - 1];
            Body.Add(tail);
        }

        public bool Collisions()
        {
            Point point = Body[0];
            for (int i = 1; i < Body.Count; i++)
            {
                if (point.X == Body[i].X && point.Y == Body[i].Y)
                    return true;
            }
            return false;
        }

        public void ChangeDirection(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (_direction != Direction.Down) _direction = Direction.Up;
                    break;
                case ConsoleKey.DownArrow:
                    if (_direction != Direction.Up) _direction = Direction.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    if (_direction != Direction.Right) _direction = Direction.Left;
                    break;
                case ConsoleKey.RightArrow:
                    if (_direction != Direction.Left) _direction = Direction.Right;
                    break;
            }
        }
    }
}
