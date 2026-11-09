using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

/// <summary>PureQL <c>key.datetime</c>.</summary>
public sealed record KeyDatetime : IKey
{
    public KeyDatetime(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeDatetime();
}
