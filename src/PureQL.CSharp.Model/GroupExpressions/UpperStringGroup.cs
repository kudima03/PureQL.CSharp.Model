using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>upper.string@group</c>.</summary>
public sealed record UpperStringGroup : IOperator
{
    public UpperStringGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeString();
}
