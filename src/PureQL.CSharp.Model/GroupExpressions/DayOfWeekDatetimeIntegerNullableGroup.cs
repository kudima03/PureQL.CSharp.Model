using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>dayOfWeek.datetime.integer.nullable@group</c>.</summary>
public sealed record DayOfWeekDatetimeIntegerNullableGroup : IOperator
{
    public DayOfWeekDatetimeIntegerNullableGroup(
        DatetimeNullableGroup operand,
        StringNullableGroup? zone = null
    )
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeNullableGroup Operand { get; }

    public StringNullableGroup? Zone { get; }

    public IType Type => new TypeIntegerNullable();
}
