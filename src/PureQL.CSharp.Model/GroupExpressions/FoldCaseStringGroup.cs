using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>foldCase.string@group</c>.</summary>
public sealed record FoldCaseStringGroup : IOperator
{
    public FoldCaseStringGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeString();
}
