namespace UtilsCSharp.Objects;

public abstract class Point2D(int x, int y)
{
    public virtual int GetX() 
        => x;

    public virtual int GetY() 
        => y;

    public override bool Equals(object? obj)
    {
        if (obj is Point2D point)
            return Equals(point);

        return false;
    }

    public virtual bool Equals(Point2D other)
        => x == other.GetX() && y == other.GetY();

    public override int GetHashCode()
        => HashCode.Combine(x, y);

    public override string ToString()
        => $"({x},{y})";
}