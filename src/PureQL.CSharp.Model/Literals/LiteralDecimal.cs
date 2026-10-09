using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralDecimal : ILiteral
{
    public LiteralDecimal(decimal value)
    {
        Value = value;
    }

    public decimal Value { get; }

    public IType Type => new TypeDecimal();
}
