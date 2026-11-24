using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>minute.datetime.integer@group</c>.</summary>
public sealed record MinuteDatetimeIntegerGroup : IOperator
{
    public MinuteDatetimeIntegerGroup(DatetimeGroup operand, StringGroup? zone = null)
    {
        Operand = operand;
        Zone = zone;
    }

    public DatetimeGroup Operand { get; }

    public StringGroup? Zone { get; }

    public IType Type => new TypeInteger();
}
