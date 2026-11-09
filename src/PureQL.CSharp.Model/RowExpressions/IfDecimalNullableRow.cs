using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.decimal.nullable@row</c>.</summary>
public sealed record IfDecimalNullableRow : IOperator
{
    public IfDecimalNullableRow(
        DecimalNullableRow then,
        DecimalNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalNullableRow Then { get; }

    public DecimalNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeDecimalNullable();
}
