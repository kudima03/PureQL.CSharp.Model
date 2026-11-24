using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.date.nullable@total</c>.</summary>
public sealed record AsNullableDateNullableTotal : IOperator
{
    public AsNullableDateNullableTotal(DateTotal operand)
    {
        Operand = operand;
    }

    public DateTotal Operand { get; }

    public IType Type => new TypeDateNullable();
}
