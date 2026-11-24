using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime.nullable@group</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeNullableGroup : IOperator
{
    public DatetimeAddSecondsDatetimeNullableGroup(
        DatetimeNullableGroup operand,
        DecimalNullableGroup seconds
    )
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeNullableGroup Operand { get; }

    public DecimalNullableGroup Seconds { get; }

    public IType Type => new TypeDatetimeNullable();
}
