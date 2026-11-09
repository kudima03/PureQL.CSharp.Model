using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.boolean.nullable@row</c>.</summary>
public sealed record IfBooleanNullableRow : IOperator
{
    public IfBooleanNullableRow(
        BooleanNullableRow then,
        BooleanNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public BooleanNullableRow Then { get; }

    public BooleanNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeBooleanNullable();
}
