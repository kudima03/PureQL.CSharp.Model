using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>second.time.integer@group</c>.</summary>
public sealed record SecondTimeIntegerGroup : IOperator
{
    public SecondTimeIntegerGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeInteger();
}
