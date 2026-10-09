using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyStringNullable : IGroupKey
{
    public GroupKeyStringNullable(StringNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public StringNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeStringNullable();
}
