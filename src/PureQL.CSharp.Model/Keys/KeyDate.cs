using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

/// <summary>PureQL <c>key.date</c>.</summary>
public sealed record KeyDate : IKey
{
    public KeyDate(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeDate();
}
