public struct Vector2
{
    // Поля X та Y координат
    public double X;
    public double Y;

    // Конструктор
    public Vector2(double x, double y)
    {
        X = x;
        Y = y;
    }

    // Статичні властивості стандартних векторів
    public static Vector2 Up => new Vector2(0, 1);
    public static Vector2 Down => new Vector2(0, -1);
    public static Vector2 Left => new Vector2(-1, 0);
    public static Vector2 Right => new Vector2(1, 0);
    public static Vector2 One => new Vector2(1, 1);
    public static Vector2 Zero => new Vector2(0, 0);

    // Статичний метод для додавання двох векторів
    public static Vector2 Add(Vector2 a, Vector2 b)
    {
        return new Vector2(a.X + b.X, a.Y + b.Y);
    }

    // Метод для наочного виведення вектора (для демонстрації)
    public override string ToString()
    {
        return $"({X}, {Y})";
    }
}

