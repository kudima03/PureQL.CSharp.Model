using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDateNullable : IGroupKey
{
    public GroupKeyDateNullable(DateNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public DateNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeDateNullable();
}
