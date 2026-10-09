using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyBooleanNullable : IGroupKey
{
    public GroupKeyBooleanNullable(BooleanNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public BooleanNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeBooleanNullable();
}
