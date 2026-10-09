using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyString : IGroupKey
{
    public GroupKeyString(StringRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public StringRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeString();
}
