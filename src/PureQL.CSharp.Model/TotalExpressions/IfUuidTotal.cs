using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfUuidTotal : IOperator
{
    public IfUuidTotal(BooleanTotal condition, UuidTotal then, UuidTotal @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public UuidTotal Then { get; }

    public UuidTotal Else { get; }

    public IType Type => new TypeUuid();
}
