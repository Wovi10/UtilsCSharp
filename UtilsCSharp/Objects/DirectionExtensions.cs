using UtilsCSharp.Enums;

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
            (0, -1) => WindDirection.North,
            (1, 0) => WindDirection.East,
            (0, 1) => WindDirection.South,
            (-1, 0) => WindDirection.West,
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
            (0, -1) => Direction.Up,
            (1, 0) => Direction.Right,
            (0, 1) => Direction.Down,
            (-1, 0) => Direction.Left,
            _ => Direction.None
        };
    }

    public static (int, int) ToOffset(this Direction direction)
    {
        return direction switch
        {
            Direction.Up => (0, -1),
            Direction.Right => (1, 0),
            Direction.Down => (0, 1),
            Direction.Left => (-1, 0),
            _ => (0, 0)
        };
    }

    public static (int, int) ToOffset(this WindDirection direction)
    {
        return direction switch
        {
            WindDirection.North => (0, -1),
            WindDirection.East => (1, 0),
            WindDirection.South => (0, 1),
            WindDirection.West => (-1, 0),
            _ => (0, 0)
        };
    }
}