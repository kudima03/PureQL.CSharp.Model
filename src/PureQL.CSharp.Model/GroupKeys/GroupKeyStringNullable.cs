using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyStringNullable : IGroupKey
{
    public GroupKeyStringNullable(string alias, ExactStringNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactStringNullableRow Expression { get; }

    public IType Type => new TypeStringNullable();
}
