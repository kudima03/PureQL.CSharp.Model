using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tryAsBoolean@row</c>.</summary>
public sealed record TryAsBooleanRow : IOperator
{
    public TryAsBooleanRow(StringNullableRow operand)
    {
        Operand = operand;
    }

    public StringNullableRow Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
