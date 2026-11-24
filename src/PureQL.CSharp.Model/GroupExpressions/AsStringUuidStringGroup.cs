using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.uuid.string@group</c>.</summary>
public sealed record AsStringUuidStringGroup : IOperator
{
    public AsStringUuidStringGroup(UuidGroup operand)
    {
        Operand = operand;
    }

    public UuidGroup Operand { get; }

    public IType Type => new TypeString();
}
