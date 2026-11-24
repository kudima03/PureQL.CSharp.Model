using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asTime.string.time@group</c>.</summary>
public sealed record AsTimeStringTimeGroup : IOperator
{
    public AsTimeStringTimeGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeTime();
}
