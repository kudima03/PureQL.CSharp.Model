using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListSubqueryColumnDatetime
{
    public ListSubqueryColumnDatetime(
        string subquery,
        string field,
        bool nullable = false
    )
    {
        Subquery = subquery;
        Field = field;
        Nullable = nullable;
    }

    public string Subquery { get; }

    public string Field { get; }

    public bool Nullable { get; }

    public IType Type => Nullable ? new TypeDatetimeNullable() : new TypeDatetime();
}
