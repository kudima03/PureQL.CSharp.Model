using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDecimalNullable : IGroupKey
{
    public GroupKeyDecimalNullable(string alias, ExactDecimalNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalNullableRow Expression { get; }

    public IType Type => new TypeDecimalNullable();
}
