using UtilsCSharp.Enums;

namespace UtilsCSharp.Objects;

public abstract class NodeBase<T>(T internalX, T internalY) where T : struct
{
    public T X { get; } = internalX;
    public T Y { get; } = internalY;

    public override bool Equals(object? obj)
    {
        if (obj is NodeBase<T> point)
            return EqualityComparer<T>.Default.Equals(X, point.X) && EqualityComparer<T>.Default.Equals(Y, point.Y);

        return false;
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hash = 17;
            hash = hash * 23 + EqualityComparer<T>.Default.GetHashCode(X);
            hash = hash * 23 + EqualityComparer<T>.Default.GetHashCode(Y);
            return hash;
        }
    }

    public override string ToString()
        => $"({X},{Y})";

    public void Deconstruct(out T x, out T y)
    {
        x = X;
        y = Y;
    }

    public static bool operator ==(NodeBase<T>? left, NodeBase<T>? right)
    {
        if (left is null && right is null)
            return true;
        
        if (left is null || right is null)
            return false;

        return left.Equals(right);
    }

    public static bool operator !=(NodeBase<T>? left, NodeBase<T>? right)
    {
        if (left is null && right is null)
            return false;
        
        if (left is null || right is null)
            return true;

        return !left.Equals(right);
    }

    public abstract (T, T) Move(Direction direction, int distance = 1);
}