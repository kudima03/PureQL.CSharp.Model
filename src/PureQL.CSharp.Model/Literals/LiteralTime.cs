using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.time</c>.</summary>
public sealed record LiteralTime : ILiteral
{
    public LiteralTime(TimeOnly value)
    {
        Value = value;
    }

    public TimeOnly Value { get; }

    public IType Type => new TypeTime();
}
