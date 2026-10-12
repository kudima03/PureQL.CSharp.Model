using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyBooleanNullable : IGroupKey
{
    public GroupKeyBooleanNullable(string alias, ExactBooleanNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactBooleanNullableRow Expression { get; }

    public IType Type => new TypeBooleanNullable();
}
