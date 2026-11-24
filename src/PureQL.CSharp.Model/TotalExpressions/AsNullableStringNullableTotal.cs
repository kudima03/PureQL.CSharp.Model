using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.string.nullable@total</c>.</summary>
public sealed record AsNullableStringNullableTotal : IOperator
{
    public AsNullableStringNullableTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeStringNullable();
}
