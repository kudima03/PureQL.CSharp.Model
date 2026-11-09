using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.boolean</c>.</summary>
public sealed record LiteralBoolean : ILiteral
{
    public LiteralBoolean(bool value)
    {
        Value = value;
    }

    public bool Value { get; }

    public IType Type => new TypeBoolean();
}
