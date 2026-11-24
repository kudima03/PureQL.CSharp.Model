using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asTime.datetime.time@group</c>.</summary>
public sealed record AsTimeDatetimeTimeGroup : IOperator
{
    public AsTimeDatetimeTimeGroup(DatetimeGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeTime();
}
