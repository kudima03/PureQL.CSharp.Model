using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>if.decimal@total</c>.</summary>
public sealed record IfDecimalTotal : IOperator
{
    public IfDecimalTotal(DecimalTotal then, DecimalTotal @else, BooleanTotal condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalTotal Then { get; }

    public DecimalTotal Else { get; }

    public BooleanTotal Condition { get; }

    public IType Type => new TypeDecimal();
}
