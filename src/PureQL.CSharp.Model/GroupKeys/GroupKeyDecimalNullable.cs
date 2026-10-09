using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDecimalNullable : IGroupKey
{
    public GroupKeyDecimalNullable(DecimalNullableRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public DecimalNullableRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeDecimalNullable();
}
