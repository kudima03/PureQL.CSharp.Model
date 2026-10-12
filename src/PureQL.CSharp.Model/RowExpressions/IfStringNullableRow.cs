using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record IfStringNullableRow : IOperator
{
    public IfStringNullableRow(
        BooleanRow condition,
        StringNullableRow then,
        StringNullableRow @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanRow Condition { get; }

    public StringNullableRow Then { get; }

    public StringNullableRow Else { get; }

    public IType Type => new TypeStringNullable();
}
