using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.date.nullable@row</c>.</summary>
public sealed record IfDateNullableRow : IOperator
{
    public IfDateNullableRow(
        DateNullableRow then,
        DateNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DateNullableRow Then { get; }

    public DateNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeDateNullable();
}
