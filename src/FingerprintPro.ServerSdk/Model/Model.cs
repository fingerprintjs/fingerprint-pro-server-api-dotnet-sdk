using System.Text.Json;

namespace FingerprintPro.ServerSdk.Model;

public abstract class Model<T> : IEquatable<T>
{
    /// <summary>
    /// Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        return JsonSerializer.Serialize(this, options);
    }

    public abstract bool Equals(T? other);
}