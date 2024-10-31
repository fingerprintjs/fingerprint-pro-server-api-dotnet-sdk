namespace FingerprintPro.ServerSdk.Model;

public class DictionaryModel<TKey, TValue> : Dictionary<TKey, TValue>, IEquatable<DictionaryModel<TKey, TValue>>
    where TKey : notnull
{
    /// <summary>
    /// Returns true if Tag instances are equal
    /// </summary>
    /// <param name="input">Instance of Tag to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DictionaryModel<TKey, TValue>? input)
    {
        if (input == null)
            return false;

        // Dict of values that are different from input
        var dict = this.Where(entry => input[entry.Key]?.Equals(entry.Value) ?? false)
            .ToDictionary(entry => entry.Key, entry => entry.Value);

        return dict.Count == 0;
    }
}