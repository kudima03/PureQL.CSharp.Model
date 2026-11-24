using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfMonth.datetime@group</c>.</summary>
public sealed record StartOfMonthDatetimeGroup : IOperator
{
    public StartOfMonthDatetimeGroup(DatetimeGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeDatetime();
}
