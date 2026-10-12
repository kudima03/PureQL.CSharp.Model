using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDatetimeNullable : IGroupKey
{
    public GroupKeyDatetimeNullable(string alias, ExactDatetimeNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDatetimeNullableRow Expression { get; }

    public IType Type => new TypeDatetimeNullable();
}
