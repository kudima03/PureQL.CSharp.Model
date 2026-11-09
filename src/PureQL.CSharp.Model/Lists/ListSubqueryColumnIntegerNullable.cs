using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListSubqueryColumnIntegerNullable : ISubqueryColumn
{
    public ListSubqueryColumnIntegerNullable(string subquery, string field)
    {
        Subquery = subquery;
        Field = field;
    }

    public string Subquery { get; }

    public string Field { get; }

    public IType Type => new TypeIntegerNullable();
}
