using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDate : IGroupKey
{
    public GroupKeyDate(string alias, DateRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public DateRow Expression { get; }

    public IType Type => new TypeDate();
}
