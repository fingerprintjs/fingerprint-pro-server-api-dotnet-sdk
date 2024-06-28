using System.Text.Json;
using System.Text.Json.Serialization;

namespace FingerprintPro.ServerSdk.Json;

public static class JsonUtils
{
    private static readonly JsonSerializerOptions SerializerOptions = new()
    {
        Converters = { new JsonEnumMemberStringEnumConverter() },
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        IncludeFields = true,

    };

    public static object? Deserialize(string data, Type returnType)
    {
        return JsonSerializer.Deserialize(data, returnType, SerializerOptions);
    }

    public static T? Deserialize<T>(string data)
    {
        return JsonSerializer.Deserialize<T>(data, SerializerOptions);
    }

    public static string Serialize(object model)
    {
        return JsonSerializer.Serialize(model, SerializerOptions);
    }
}
