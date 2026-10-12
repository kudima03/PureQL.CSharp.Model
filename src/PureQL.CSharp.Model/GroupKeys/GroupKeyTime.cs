using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyTime : IGroupKey
{
    public GroupKeyTime(string alias, TimeRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public TimeRow Expression { get; }

    public IType Type => new TypeTime();
}
