using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeAddSeconds.datetime@group</c>.</summary>
public sealed record DatetimeAddSecondsDatetimeGroup : IOperator
{
    public DatetimeAddSecondsDatetimeGroup(DatetimeGroup left, DecimalGroup right)
    {
        Left = left;
        Right = right;
    }

    public DatetimeGroup Left { get; }

    public DecimalGroup Right { get; }

    public IType Type => new TypeDatetime();
}
