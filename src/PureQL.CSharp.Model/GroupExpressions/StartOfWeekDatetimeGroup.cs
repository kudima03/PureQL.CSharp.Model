using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfWeek.datetime@group</c>.</summary>
public sealed record StartOfWeekDatetimeGroup : IOperator
{
    public StartOfWeekDatetimeGroup(DatetimeGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeDatetime();
}
