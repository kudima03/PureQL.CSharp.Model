using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IfDecimalGroup : IOperator
{
    public IfDecimalGroup(BooleanGroup condition, DecimalGroup then, DecimalGroup @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanGroup Condition { get; }

    public DecimalGroup Then { get; }

    public DecimalGroup Else { get; }

    public IType Type => new TypeDecimal();
}
