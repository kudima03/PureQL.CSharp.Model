using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyTimeNullable : IGroupKey
{
    public GroupKeyTimeNullable(string alias, ExactTimeNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactTimeNullableRow Expression { get; }

    public IType Type => new TypeTimeNullable();
}
