using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListSubqueryColumnDecimal
{
    public ListSubqueryColumnDecimal(string subquery, string field, bool nullable = false)
    {
        Subquery = subquery;
        Field = field;
        Nullable = nullable;
    }

    public string Subquery { get; }

    public string Field { get; }

    public bool Nullable { get; }

    public IType Type => Nullable ? new TypeDecimalNullable() : new TypeDecimal();
}
