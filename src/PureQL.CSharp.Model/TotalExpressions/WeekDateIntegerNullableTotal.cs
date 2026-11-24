using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>week.date.integer.nullable@total</c>.</summary>
public sealed record WeekDateIntegerNullableTotal : IOperator
{
    public WeekDateIntegerNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
