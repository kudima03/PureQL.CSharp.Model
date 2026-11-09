using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>not@group</c>.</summary>
public sealed record NotGroup : IOperator
{
    public NotGroup(BooleanGroup condition)
    {
        Condition = condition;
    }

    public BooleanGroup Condition { get; }

    public IType Type => new TypeBoolean();
}
