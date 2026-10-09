using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralTime : ILiteral
{
    public LiteralTime(TimeOnly value)
    {
        Value = value;
    }

    public TimeOnly Value { get; }

    public IType Type => new TypeTime();
}
