using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyIntegerNullable : IGroupKey
{
    public GroupKeyIntegerNullable(string alias, ExactIntegerNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactIntegerNullableRow Expression { get; }

    public IType Type => new TypeIntegerNullable();
}
