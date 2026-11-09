using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.time.nullable@row</c>.</summary>
public sealed record IfTimeNullableRow : IOperator
{
    public IfTimeNullableRow(
        TimeNullableRow then,
        TimeNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public TimeNullableRow Then { get; }

    public TimeNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeTimeNullable();
}
