using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyUuid : IGroupKey
{
    public GroupKeyUuid(UuidRow expression, string? alias = null)
    {
        Expression = expression;
        Alias = alias;
    }

    public UuidRow Expression { get; }

    public string? Alias { get; }

    public IType Type => new TypeUuid();
}
