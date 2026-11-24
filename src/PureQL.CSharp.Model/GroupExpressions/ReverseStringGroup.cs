using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>reverse.string@group</c>.</summary>
public sealed record ReverseStringGroup : IOperator
{
    public ReverseStringGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeString();
}
