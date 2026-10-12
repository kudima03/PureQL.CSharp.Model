using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyDecimal : IGroupKey
{
    public GroupKeyDecimal(string alias, ExactDecimalRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactDecimalRow Expression { get; }

    public IType Type => new TypeDecimal();
}
