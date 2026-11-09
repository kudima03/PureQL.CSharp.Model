using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.boolean@total</c>.</summary>
public sealed record IfBooleanTotal : IOperator
{
    public IfBooleanTotal(BooleanTotal then, BooleanTotal @else, BooleanTotal condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanTotal Then { get; }

    public BooleanTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeBoolean();
}
