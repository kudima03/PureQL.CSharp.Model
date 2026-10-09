using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyTimeNullable : IGroupKey
{
    public GroupKeyTimeNullable(TimeNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public TimeNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeTimeNullable();
}
