using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>abs.integer.nullable@total</c>.</summary>
public sealed record AbsIntegerNullableTotal : IOperator
{
    public AbsIntegerNullableTotal(DeclaresIntegerNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
