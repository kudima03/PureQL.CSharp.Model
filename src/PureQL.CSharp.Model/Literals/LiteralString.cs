using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.string</c>.</summary>
public sealed record LiteralString : ILiteral
{
    public LiteralString(string value)
    {
        Value = value;
    }

    public string Value { get; }

    public IType Type => new TypeString();
}
