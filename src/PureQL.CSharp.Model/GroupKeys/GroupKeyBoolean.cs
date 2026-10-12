using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyBoolean : IGroupKey
{
    public GroupKeyBoolean(string alias, BooleanRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public BooleanRow Expression { get; }

    public IType Type => new TypeBoolean();
}
