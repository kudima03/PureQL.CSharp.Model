using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.integer.nullable@total</c>.</summary>
public sealed record AsNullableIntegerNullableTotal : IOperator
{
    public AsNullableIntegerNullableTotal(IntegerTotal operand)
    {
        Operand = operand;
    }

    public IntegerTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
