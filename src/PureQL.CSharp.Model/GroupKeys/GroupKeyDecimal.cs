using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDecimal : IGroupKey
{
    public GroupKeyDecimal(DecimalRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public DecimalRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeDecimal();
}
