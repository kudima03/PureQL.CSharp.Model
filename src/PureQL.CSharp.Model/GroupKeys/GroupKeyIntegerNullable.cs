using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyIntegerNullable : IGroupKey
{
    public GroupKeyIntegerNullable(IntegerNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public IntegerNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeIntegerNullable();
}
