using System.Text.Json;

namespace SharedKernel.GreatNuGet;

public class CustomSerializer<T>
{
	public static string GetContent(T content) => JsonSerializer.Serialize(content);

	public static string GetContentCollection(IEnumerable<T> collection) => JsonSerializer.Serialize(collection);

	public static T GetDeserializedObject(string content) => JsonSerializer.Deserialize<T>(content);

	public static IEnumerable<T> GetDeserializedObjectCollection(string content) => JsonSerializer.Deserialize<List<T>>(content);
}