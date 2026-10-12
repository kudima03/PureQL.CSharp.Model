using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyUuid : IGroupKey
{
    public GroupKeyUuid(string alias, UuidRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public UuidRow Expression { get; }

    public IType Type => new TypeUuid();
}
