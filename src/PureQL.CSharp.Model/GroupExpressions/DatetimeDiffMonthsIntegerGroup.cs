using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>datetimeDiffMonths.integer@group</c>.</summary>
public sealed record DatetimeDiffMonthsIntegerGroup : IOperator
{
    public DatetimeDiffMonthsIntegerGroup(
        DatetimeGroup left,
        DatetimeGroup right,
        StringGroup? zone = null
    )
    {
        Left = left;
        Right = right;
        Zone = zone;
    }

    public DatetimeGroup Left { get; }

    public DatetimeGroup Right { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeInteger();
}
