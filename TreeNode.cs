using System.IO;
using System.Text.Json;

public class Node
{
    public int value { get; set; }
    public Node left { get; set; }
    public Node right { get; set; }
}
public static class TreeNode
{
    public static async Task<Node> LoadNodes()
    {
        HttpClient client = new HttpClient();
        try
        {
            string response = await client.GetStringAsync("https://crismo-turquoisejaguar.web.val.run/treeI");
            JsonDocument doc = JsonDocument.Parse(response);
            Node rootNode = new Node();
            BuildTree(doc.RootElement, rootNode);
            return rootNode;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }
    private static void BuildTree(JsonElement element, Node node)
    {
        if (element.ValueKind == JsonValueKind.Object)
        {
            foreach (JsonProperty property in element.EnumerateObject())
            {
                if (property.Name == "value")
                {
                    node.value = property.Value.GetInt32();
                }
                else if (property.Name == "left")
                {
                    node.left = new Node();
                    BuildTree(property.Value, node.left);
                }
                else if (property.Name == "right")
                {
                    node.right = new Node();
                    BuildTree(property.Value, node.right);
                }
            }
        }
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