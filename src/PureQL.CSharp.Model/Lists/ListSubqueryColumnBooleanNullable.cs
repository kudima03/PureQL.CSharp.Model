using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListSubqueryColumnBooleanNullable : ISubqueryColumn
{
    public ListSubqueryColumnBooleanNullable(string subquery, string field)
    {
        Subquery = subquery;
        Field = field;
    }

    public string Subquery { get; }

    public string Field { get; }

    public IType Type => new TypeBooleanNullable();
}
