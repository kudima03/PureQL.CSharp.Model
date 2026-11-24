namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>rowItem</c>.</summary>
public sealed record RowItem
{
    public RowItem(string alias, Cell expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public Cell Expression { get; }
}
