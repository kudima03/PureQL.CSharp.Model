using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

/// <summary>PureQL <c>key.time</c>.</summary>
public sealed record KeyTime : IKey
{
    public KeyTime(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeTime();
}
