using System.Numerics;

namespace UtilsCSharp.Utils.Sorting;

internal static class CartesianTree
{
    public static Node<T> BuildCartesianTree<T>(this List<T> list, int listLength) where T : struct, IComparable<T>
    {
        var parent = new int[listLength];
        var left = new int[listLength];
        var right = new int[listLength];

        Array.Fill(parent, -1);
        Array.Fill(left, -1);
        Array.Fill(right, -1);

        var root = 0;

        for (var i = 1; i < listLength; i++)
        {
            var last = i - 1;
            right[i] = -1;

            while (list[last].IsGreaterThanOrEqualTo(list[i]) && last != root)
                last = parent[last];

            if (list[last].IsGreaterThanOrEqualTo(list[i]))
            {
                parent[root] = i;
                left[i] = root;
                root = i;
            }
            else if (right[last] == -1)
            {
                right[last] = i;
                parent[i] = last;
                left[i] = -1;
            }
            else
            {
                parent[right[last]] = i;
                left[i] = right[last];
                right[last] = i;
                parent[i] = last;
            }
        }

        parent[root] = -1;

        return list.BuildCartesianTreeUtil(root, left, right);
    }

    private static Node<T> BuildCartesianTreeUtil<T>(this List<T> list, int root, int[] left, int[]
        right) where T : struct, IComparable<T>
    {
        if (root == -1)
            return null;

        var node = new Node<T>
        {
            Value = list[root],
            Left = list.BuildCartesianTreeUtil(left[root], left, right),
            Right = list.BuildCartesianTreeUtil(right[root], left, right)
        };

        return node;
    }

    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
    }

    public class IndexNodePair<T>(T value, Node<T> node) : IComparable<IndexNodePair<T>> where T : struct, IComparable<T>
    {
        public T Value { get; } = value;
        public Node<T> Node { get; } = node;

        public int CompareTo(IndexNodePair<T> other) => Value.CompareTo(other.Value);
    }

    public static List<T> PqBasedTraversal<T>(Node<T> rootNode) where T : struct, IComparable<T>,INumber<T>
    {
        var list = new List<T>();
        var priorityQueue = new PriorityQueue<IndexNodePair<T>>();

        priorityQueue.Enqueue(new IndexNodePair<T>(rootNode.Value, rootNode));

        while (!priorityQueue.IsEmpty())
        {
            var poppedPair = priorityQueue.Dequeue();
            list.Add(poppedPair.Value);
            
            if (poppedPair.Node.Left != null)
                priorityQueue.Enqueue(new IndexNodePair<T>(poppedPair.Node.Left.Value, poppedPair.Node.Left));

            if (poppedPair.Node.Right != null)
                priorityQueue.Enqueue(new IndexNodePair<T>(poppedPair.Node.Right.Value, poppedPair.Node.Right));
        }

        return list;
    }

    private class PriorityQueue<T> where T : IComparable<T>
    {
        private readonly List<T> _data = new();

        public bool IsEmpty() 
            => _data.Count == 0;

        public void Enqueue(T item)
        {
            _data.Add(item);
            var ci = _data.Count - 1; 
            while (ci > 0)
            {
                var pi = (ci - 1) / 2;
                if (_data[ci].CompareTo(_data[pi]) >= 0)
                    break;

                (_data[ci], _data[pi]) = (_data[pi], _data[ci]);
                ci = pi;
            }
        }

        public T Dequeue()
        {
            var li = _data.Count - 1;
            var frontItem = _data[0];
            _data[0] = _data[li];
            _data.RemoveAt(li);

            --li;
            var pi = 0;
            while (true)
            {
                var ci = pi * 2 + 1;
                if (ci > li)
                    break;

                var rc = ci + 1;
                if (rc <= li && _data[rc].CompareTo(_data[ci]) < 0)
                    ci = rc;

                if (_data[pi].CompareTo(_data[ci]) <= 0)
                    break;

                (_data[pi], _data[ci]) = (_data[ci], _data[pi]);
                pi = ci;
            }

            return frontItem;
        }
    }
}