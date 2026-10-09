using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyTime : IGroupKey
{
    public GroupKeyTime(TimeRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public TimeRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeTime();
}
