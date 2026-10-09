using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyBoolean : IGroupKey
{
    public GroupKeyBoolean(BooleanRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public BooleanRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeBoolean();
}
