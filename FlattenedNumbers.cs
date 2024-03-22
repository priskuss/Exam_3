using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

public static class FlattenedNumbers
{
    public static async Task<int[]> FetchAndFlattenArray()
    {
        HttpClient client = new HttpClient();
        try
        {
            string response = await client.GetStringAsync("https://crismo-turquoisejaguar.web.val.run/arrayI");
            JsonDocument doc = JsonDocument.Parse(response);
            List<int> flattenedList = new List<int>();
            FlattenJsonElement(doc.RootElement, flattenedList);
            return flattenedList.ToArray();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            return Array.Empty<int>();
        }
    }

    public static void FlattenJsonElement(JsonElement element, List<int> flattenedList)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Array:
                foreach (JsonElement childElement in element.EnumerateArray())
                {
                    FlattenJsonElement(childElement, flattenedList);
                }
                break;
            case JsonValueKind.Number:
                flattenedList.Add(element.GetInt32());
                break;
        }
    }

    public static int[] Flatten(object[] array)
    {
        List<int> result = new List<int>();
        foreach (var item in array)
        {
            if (item is int)
            {
                result.Add((int)item);
            }
            else
            {
                result.AddRange(Flatten((object[])item));
            }
        }
        return result.ToArray();
    }
}