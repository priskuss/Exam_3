using System.IO;
using System.Text.Json;

public class Node
{
    public int value { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }
}

public static class Left_Right_Up_Down
{
    public static Node LoadNodes()
    {
        string json_text = File.ReadAllText(@"./nodes.json");
        var nodes = JsonSerializer.Deserialize<Node>(json_text);
        return nodes;
    }
    public static int Sum(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        return node.value + Sum(node.left) + Sum(node.right);
    }

    public static int Deepest(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        return 1 + Math.Max(Deepest(node.left), Deepest(node.right));
    }

    public static int Nodes(Node node)
    {
        if (node == null)
        {
            return 0;
        }
        return 1 + Nodes(node.left) + Nodes(node.right);
    }
}