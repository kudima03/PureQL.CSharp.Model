using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfWeek.date.nullable@total</c>.</summary>
public sealed record StartOfWeekDateNullableTotal : IOperator
{
    public StartOfWeekDateNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeDateNullable();
}
