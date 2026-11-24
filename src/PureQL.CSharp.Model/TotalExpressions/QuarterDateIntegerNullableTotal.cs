using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>quarter.date.integer.nullable@total</c>.</summary>
public sealed record QuarterDateIntegerNullableTotal : IOperator
{
    public QuarterDateIntegerNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
