namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record OrGroup
{
    public OrGroup(IEnumerable<BooleanGroup> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanGroup> Conditions { get; }
}
