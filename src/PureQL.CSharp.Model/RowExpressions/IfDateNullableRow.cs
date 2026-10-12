using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfDateNullableRow : IOperator
{
    public IfDateNullableRow(
        BooleanRow condition,
        DateNullableRow then,
        DateNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public DateNullableRow Then { get; }

    public DateNullableRow Else { get; }

    public IType Type => new TypeDateNullable();
}
