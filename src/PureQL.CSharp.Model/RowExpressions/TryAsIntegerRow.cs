using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tryAsInteger@row</c>.</summary>
public sealed record TryAsIntegerRow : IOperator
{
    public TryAsIntegerRow(StringNullableRow operand)
    {
        Operand = operand;
    }

    public StringNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
