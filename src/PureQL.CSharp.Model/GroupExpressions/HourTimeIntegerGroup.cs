using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>hour.time.integer@group</c>.</summary>
public sealed record HourTimeIntegerGroup : IOperator
{
    public HourTimeIntegerGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeInteger();
}
