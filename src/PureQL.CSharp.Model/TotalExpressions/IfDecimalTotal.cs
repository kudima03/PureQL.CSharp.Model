using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record IfDecimalTotal : IOperator
{
    public IfDecimalTotal(BooleanTotal condition, DecimalTotal then, DecimalTotal @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanTotal Condition { get; }

    public DecimalTotal Then { get; }

    public DecimalTotal Else { get; }

    public IType Type => new TypeDecimal();
}
