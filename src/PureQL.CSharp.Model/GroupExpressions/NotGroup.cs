namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record NotGroup
{
    public NotGroup(BooleanGroup condition)
    {
        Condition = condition;
    }

    public BooleanGroup Condition { get; }
}
