using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

/// <summary>PureQL <c>key.integer</c>.</summary>
public sealed record KeyInteger : IKey
{
    public KeyInteger(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeInteger();
}
