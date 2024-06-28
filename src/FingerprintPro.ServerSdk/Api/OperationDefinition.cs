
using System.Text.Json;

namespace FingerprintPro.ServerSdk.Api;

public abstract class OperationDefinition
{
    public abstract string Path { get; }

    public abstract string OperationName { get; }

    public abstract string[] PathParams { get; }

    public abstract Dictionary<int, Type> ResponseStatusCodeMap { get; }

    public string GetPath(params string[] args)
    {
        var path = Path;

        for (var i = 0; i < args.Length; i++)
        {
            path = path.Replace("{" + PathParams[i] + "}", args[i]);
        }

        return path;
    }
}
