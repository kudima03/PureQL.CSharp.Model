using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.boolean.string@group</c>.</summary>
public sealed record AsStringBooleanStringGroup : IOperator
{
    public AsStringBooleanStringGroup(BooleanGroup operand)
    {
        Operand = operand;
    }

    public BooleanGroup Operand { get; }

    public IType Type => new TypeString();
}
