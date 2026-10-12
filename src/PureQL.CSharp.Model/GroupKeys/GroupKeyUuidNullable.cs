using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public sealed record GroupKeyUuidNullable : IGroupKey
{
    public GroupKeyUuidNullable(string alias, ExactUuidNullableRow expression)
    {
        Alias = alias;
        Expression = expression;
    }

    public string Alias { get; }

    public ExactUuidNullableRow Expression { get; }

    public IType Type => new TypeUuidNullable();
}
