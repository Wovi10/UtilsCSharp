namespace UtilsCSharp.Objects;

public abstract class Node(int internalX, int internalY)
{
    public int X { get; } = internalX;
    public int Y { get; } = internalY;

    public override bool Equals(object? obj)
    {
        if (obj is Node point)
            return Equals(point);

        return false;
    }

    public virtual bool Equals(Node other)
        => X == other.X && Y == other.Y;

    public override int GetHashCode()
        => HashCode.Combine(X, Y);

    public override string ToString()
        => $"({X},{Y})";
}