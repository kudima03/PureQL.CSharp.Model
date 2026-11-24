using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.time.string@group</c>.</summary>
public sealed record AsStringTimeStringGroup : IOperator
{
    public AsStringTimeStringGroup(TimeGroup operand)
    {
        Operand = operand;
    }

    public TimeGroup Operand { get; }

    public IType Type => new TypeString();
}
