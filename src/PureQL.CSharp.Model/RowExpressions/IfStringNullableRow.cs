using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>if.string.nullable@row</c>.</summary>
public sealed record IfStringNullableRow : IOperator
{
    public IfStringNullableRow(
        StringNullableRow then,
        StringNullableRow @else,
        BooleanRow condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringNullableRow Then { get; }

    public StringNullableRow Else { get; }

    public BooleanRow Condition { get; }

    public IType Type => new TypeStringNullable();
}
