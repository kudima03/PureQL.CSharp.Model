using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.string.nullable@group</c>.</summary>
public sealed record AsNullableStringNullableGroup : IOperator
{
    public AsNullableStringNullableGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
