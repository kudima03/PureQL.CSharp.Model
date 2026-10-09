namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AndGroup
{
    public AndGroup(IEnumerable<BooleanGroup> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanGroup> Conditions { get; }
}
