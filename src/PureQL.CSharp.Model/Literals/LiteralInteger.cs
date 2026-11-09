using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.integer</c>.</summary>
public sealed record LiteralInteger : ILiteral
{
    public LiteralInteger(long value)
    {
        Value = value;
    }

    public long Value { get; }

    public IType Type => new TypeInteger();
}
