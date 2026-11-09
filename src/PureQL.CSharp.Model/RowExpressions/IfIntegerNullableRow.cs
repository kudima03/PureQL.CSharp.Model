using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.integer.nullable@row</c>.</summary>
public sealed record IfIntegerNullableRow : IOperator
{
    public IfIntegerNullableRow(
        IntegerNullableRow then,
        IntegerNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerNullableRow Then { get; }

    public IntegerNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeIntegerNullable();
}
