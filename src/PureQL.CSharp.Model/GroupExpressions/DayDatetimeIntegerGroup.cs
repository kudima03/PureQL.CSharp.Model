using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>day.datetime.integer@group</c>.</summary>
public sealed record DayDatetimeIntegerGroup : IOperator
{
    public DayDatetimeIntegerGroup(DatetimeGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeInteger();
}
