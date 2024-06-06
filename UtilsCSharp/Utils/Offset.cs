namespace UtilsCSharp.Utils;

public static class Offset
{
    public static readonly (int, int) Up = (0, 1);
    public static readonly (int, int) Right = (1, 0);
    public static readonly (int, int) Down = (0, -1);
    public static readonly (int, int) Left = (-1, 0);
    public static readonly (int, int) Still = (0, 0);

    public static readonly List<(int, int)> Offsets = new()
    {
        Up,
        Right,
        Down,
        Left
    };
}