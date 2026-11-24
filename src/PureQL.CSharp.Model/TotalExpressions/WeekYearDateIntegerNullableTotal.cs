using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>weekYear.date.integer.nullable@total</c>.</summary>
public sealed record WeekYearDateIntegerNullableTotal : IOperator
{
    public WeekYearDateIntegerNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
