using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralInteger : ILiteral
{
    public LiteralInteger(long value)
    {
        Value = value;
    }

    public long Value { get; }

    public IType Type => new TypeInteger();
}
