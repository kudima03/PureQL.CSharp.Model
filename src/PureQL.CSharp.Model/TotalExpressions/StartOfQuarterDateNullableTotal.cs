using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfQuarter.date.nullable@total</c>.</summary>
public sealed record StartOfQuarterDateNullableTotal : IOperator
{
    public StartOfQuarterDateNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeDateNullable();
}
