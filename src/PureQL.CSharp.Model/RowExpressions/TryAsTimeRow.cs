using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tryAsTime@row</c>.</summary>
public sealed record TryAsTimeRow : IOperator
{
    public TryAsTimeRow(StringNullableRow operand)
    {
        Operand = operand;
    }

    public StringNullableRow Operand { get; }

    public IType Type => new TypeTimeNullable();
}
