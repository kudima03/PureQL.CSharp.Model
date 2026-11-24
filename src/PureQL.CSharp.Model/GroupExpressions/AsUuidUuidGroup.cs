using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asUuid.uuid@group</c>.</summary>
public sealed record AsUuidUuidGroup : IOperator
{
    public AsUuidUuidGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeUuid();
}
