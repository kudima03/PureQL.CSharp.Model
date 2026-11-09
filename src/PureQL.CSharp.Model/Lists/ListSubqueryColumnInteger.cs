using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListSubqueryColumnInteger : ISubqueryColumn
{
    public ListSubqueryColumnInteger(string subquery, string field)
    {
        Subquery = subquery;
        Field = field;
    }

    public string Subquery { get; }

    public string Field { get; }

    public IType Type => new TypeInteger();
}
