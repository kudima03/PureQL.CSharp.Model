using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyInteger : IGroupKey
{
    public GroupKeyInteger(IntegerRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public IntegerRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeInteger();
}
