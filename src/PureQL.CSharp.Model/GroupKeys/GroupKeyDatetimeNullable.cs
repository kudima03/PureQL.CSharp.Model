using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDatetimeNullable : IGroupKey
{
    public GroupKeyDatetimeNullable(DatetimeNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public DatetimeNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeDatetimeNullable();
}
