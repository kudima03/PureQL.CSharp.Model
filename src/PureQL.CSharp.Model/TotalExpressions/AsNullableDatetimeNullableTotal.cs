using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.datetime.nullable@total</c>.</summary>
public sealed record AsNullableDatetimeNullableTotal : IOperator
{
    public AsNullableDatetimeNullableTotal(DatetimeTotal operand)
    {
        Operand = operand;
    }

    public DatetimeTotal Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
