using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyInteger : IGroupKey
{
    public GroupKeyInteger(string alias, IntegerRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public IntegerRow Expression { get; }

    public IType Type => new TypeInteger();
}
