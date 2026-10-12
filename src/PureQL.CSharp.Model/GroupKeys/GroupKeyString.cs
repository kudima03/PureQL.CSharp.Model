using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyString : IGroupKey
{
    public GroupKeyString(string alias, StringRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public StringRow Expression { get; }

    public IType Type => new TypeString();
}
