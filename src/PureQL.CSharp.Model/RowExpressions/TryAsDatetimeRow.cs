using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tryAsDatetime@row</c>.</summary>
public sealed record TryAsDatetimeRow : IOperator
{
    public TryAsDatetimeRow(StringNullableRow operand)
    {
        Operand = operand;
    }

    public StringNullableRow Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
