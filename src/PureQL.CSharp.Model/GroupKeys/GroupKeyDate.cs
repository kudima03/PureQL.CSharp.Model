using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDate : IGroupKey
{
    public GroupKeyDate(DateRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public DateRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeDate();
}
