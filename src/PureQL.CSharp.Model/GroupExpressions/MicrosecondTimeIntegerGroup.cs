using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>microsecond.time.integer@group</c>.</summary>
public sealed record MicrosecondTimeIntegerGroup : IOperator
{
    public MicrosecondTimeIntegerGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeInteger();
}
