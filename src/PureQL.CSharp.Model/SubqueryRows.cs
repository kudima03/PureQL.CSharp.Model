namespace PureQL.CSharp.Model;

public sealed record SubqueryRows
{
    public SubqueryRows(string name, IEnumerable<IEnumerable<RowItem>> rows)
    {
        Name = name;
        Rows = rows;
    }

    public string Name { get; }

    public IEnumerable<IEnumerable<RowItem>> Rows { get; }
}
