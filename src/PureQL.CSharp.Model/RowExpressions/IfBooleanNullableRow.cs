using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfBooleanNullableRow : IOperator
{
    public IfBooleanNullableRow(
        BooleanRow condition,
        BooleanNullableRow then,
        BooleanNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public BooleanNullableRow Then { get; }

    public BooleanNullableRow Else { get; }

    public IType Type => new TypeBooleanNullable();
}
