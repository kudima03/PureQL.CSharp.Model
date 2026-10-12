using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDatetime : IGroupKey
{
    public GroupKeyDatetime(string alias, DatetimeRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DatetimeRow Expression { get; }

    public IType Type => new TypeDatetime();
}
