using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>startOfYear.date.nullable@total</c>.</summary>
public sealed record StartOfYearDateNullableTotal : IOperator
{
    public StartOfYearDateNullableTotal(DeclaresDateNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableTotal Operand { get; }

    public IType Type => new TypeDateNullable();
}
