using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfHour.datetime@group</c>.</summary>
public sealed record StartOfHourDatetimeGroup : IOperator
{
    public StartOfHourDatetimeGroup(DatetimeGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeDatetime();
}
