using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>or@group</c>.</summary>
public sealed record OrGroup : IOperator
{
    public OrGroup(IEnumerable<BooleanGroup> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanGroup> Conditions { get; }

    public IType Type => new TypeBoolean();
}
