using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDecimalNullableRow : IOperator
{
    public IfDecimalNullableRow(
        BooleanRow condition,
        DecimalNullableRow then,
        DecimalNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DecimalNullableRow Then { get; }

    public DecimalNullableRow Else { get; }

    public IType Type => new TypeDecimalNullable();
}
