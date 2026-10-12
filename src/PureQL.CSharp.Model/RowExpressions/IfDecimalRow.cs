using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDecimalRow : IOperator
{
    public IfDecimalRow(BooleanRow condition, DecimalRow then, DecimalRow @else)
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DecimalRow Then { get; }

    public DecimalRow Else { get; }

    public IType Type => new TypeDecimal();
}
