using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>quarter.datetime.integer@group</c>.</summary>
public sealed record QuarterDatetimeIntegerGroup : IOperator
{
    public QuarterDatetimeIntegerGroup(DatetimeGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeInteger();
}
