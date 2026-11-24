using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfMonth.date.nullable@total</c>.</summary>
public sealed record StartOfMonthDateNullableTotal : IOperator
{
    public StartOfMonthDateNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeDateNullable();
}
