using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDateNullable : IGroupKey
{
    public GroupKeyDateNullable(string alias, ExactDateNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDateNullableRow Expression { get; }

    public IType Type => new TypeDateNullable();
}
