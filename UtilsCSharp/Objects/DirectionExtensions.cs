using UtilsCSharp.Enums;
using UtilsCSharp.Utils;

namespace UtilsCSharp.Objects;

public static class DirectionExtensions
{
    public static WindDirection ToWindDirection(this Direction direction)
    {
        return direction switch
        {
            Direction.Up => WindDirection.North,
            Direction.Right => WindDirection.East,
            Direction.Down => WindDirection.South,
            Direction.Left => WindDirection.West,
            _ => WindDirection.None
        };
    }

    public static WindDirection ToWindDirection(this (int, int) offset)
    {
        return offset switch
        {
            _ when offset == Offset.Up => WindDirection.North,
            _ when offset == Offset.Right => WindDirection.East,
            _ when offset == Offset.Down => WindDirection.South,
            _ when offset == Offset.Left => WindDirection.West,
            _ => WindDirection.None
        };
    }

    public static Direction ToDirection(this WindDirection direction)
    {
        return direction switch
        {
            WindDirection.North => Direction.Up,
            WindDirection.East => Direction.Right,
            WindDirection.South => Direction.Down,
            WindDirection.West => Direction.Left,
            _ => Direction.None
        };
    }

    public static Direction ToDirection(this (int, int) offset)
    {
        return offset switch
        {
            _ when offset == Offset.Up => Direction.Up,
            _ when offset == Offset.Right => Direction.Right,
            _ when offset == Offset.Down => Direction.Down,
            _ when offset == Offset.Left => Direction.Left,
            _ => Direction.None
        };
    }

    public static (int, int) ToOffset(this Direction direction)
    {
        return direction switch
        {
            Direction.Up => Offset.Up,
            Direction.Right => Offset.Right,
            Direction.Down => Offset.Down,
            Direction.Left => Offset.Left,
            _ => Offset.Still
        };
    }

    public static (int, int) ToOffset(this WindDirection direction)
    {
        return direction switch
        {
            WindDirection.North => Offset.Up,
            WindDirection.East => Offset.Right,
            WindDirection.South => Offset.Down,
            WindDirection.West => Offset.Left,
            _ => Offset.Still
        };
    }
}