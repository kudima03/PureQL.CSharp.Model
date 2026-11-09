using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.datetime.nullable@row</c>.</summary>
public sealed record IfDatetimeNullableRow : IOperator
{
    public IfDatetimeNullableRow(
        DatetimeNullableRow then,
        DatetimeNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DatetimeNullableRow Then { get; }

    public DatetimeNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeDatetimeNullable();
}
