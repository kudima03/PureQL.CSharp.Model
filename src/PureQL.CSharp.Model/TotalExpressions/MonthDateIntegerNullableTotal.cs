using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>month.date.integer.nullable@total</c>.</summary>
public sealed record MonthDateIntegerNullableTotal : IOperator
{
    public MonthDateIntegerNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
