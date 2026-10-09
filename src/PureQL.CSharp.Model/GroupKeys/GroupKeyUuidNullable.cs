using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyUuidNullable : IGroupKey
{
    public GroupKeyUuidNullable(UuidNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public UuidNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeUuidNullable();
}
