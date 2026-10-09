using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDatetime : IGroupKey
{
    public GroupKeyDatetime(DatetimeRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public DatetimeRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeDatetime();
}
