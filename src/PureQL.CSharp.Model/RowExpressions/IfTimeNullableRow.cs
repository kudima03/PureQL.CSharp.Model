using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfTimeNullableRow : IOperator
{
    public IfTimeNullableRow(
        BooleanRow condition,
        TimeNullableRow then,
        TimeNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public TimeNullableRow Then { get; }

    public TimeNullableRow Else { get; }

    public IType Type => new TypeTimeNullable();
}
