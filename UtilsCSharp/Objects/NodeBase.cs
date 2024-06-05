using UtilsCSharp.Enums;

namespace UtilsCSharp.Objects;

public abstract class NodeBase(int internalX, int internalY)
{
    public int X { get; } = internalX;
    public int Y { get; } = internalY;

    public override bool Equals(object? obj)
    {
        if (obj is NodeBase point)
            return Equals(point);

        return false;
    }

    public virtual bool Equals(NodeBase other)
        => X == other.X && Y == other.Y;

    public override int GetHashCode()
        => HashCode.Combine(X, Y);

    public override string ToString()
        => $"({X},{Y})";

    public void Deconstruct(out int x, out int y)
    {
        x = X;
        y = Y;
    }

    public static bool operator ==(NodeBase left, NodeBase right)
        => left.Equals(right);

    public static bool operator !=(NodeBase left, NodeBase right)
        => !left.Equals(right);

    public abstract NodeBase Move(Direction direction);
}