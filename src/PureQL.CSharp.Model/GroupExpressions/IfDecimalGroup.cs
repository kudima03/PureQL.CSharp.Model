using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>if.decimal@group</c>.</summary>
public sealed record IfDecimalGroup : IOperator
{
    public IfDecimalGroup(DecimalGroup then, DecimalGroup @else, BooleanGroup condition)
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalGroup Then { get; }

    public DecimalGroup Else { get; }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeDecimal();
}
