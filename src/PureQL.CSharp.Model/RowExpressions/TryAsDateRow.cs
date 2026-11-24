using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tryAsDate@row</c>.</summary>
public sealed record TryAsDateRow : IOperator
{
    public TryAsDateRow(StringNullableRow operand)
    {
        Operand = operand;
    }

    public StringNullableRow Operand { get; }

    public IType Type => new TypeDateNullable();
}
