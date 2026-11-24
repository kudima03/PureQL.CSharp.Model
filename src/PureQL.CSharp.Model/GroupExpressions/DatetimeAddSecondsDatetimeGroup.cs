using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@group</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeGroup : IOperator
{
    public DatetimeAddSecondsDatetimeGroup(DatetimeGroup operand, DecimalGroup seconds)
    {
        Operand = operand;
        Seconds = seconds;
    }

    public DatetimeGroup Operand { get; }

    public DecimalGroup Seconds { get; }

    public IType Type => new TypeDatetime();
}
