namespace PureQL.CSharp.Model;

public sealed record FromExpression
{
    public FromExpression(string entity, string alias)
    {
        Entity = entity;
        Alias = alias;
    }

    public string Entity { get; }

    public string Alias { get; }
}
