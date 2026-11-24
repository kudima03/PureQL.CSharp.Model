using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.date.string@group</c>.</summary>
public sealed record AsStringDateStringGroup : IOperator
{
    public AsStringDateStringGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeString();
}
