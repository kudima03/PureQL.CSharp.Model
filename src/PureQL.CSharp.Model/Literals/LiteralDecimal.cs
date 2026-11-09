using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.decimal</c>.</summary>
public sealed record LiteralDecimal : ILiteral
{
    public LiteralDecimal(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; }

    public IType Type => new TypeDecimal();
}
