using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>minute.time.integer@group</c>.</summary>
public sealed record MinuteTimeIntegerGroup : IOperator
{
    public MinuteTimeIntegerGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeInteger();
}
