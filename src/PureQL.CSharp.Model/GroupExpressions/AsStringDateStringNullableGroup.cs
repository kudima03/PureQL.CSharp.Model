using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.date.string.nullable@group</c>.</summary>
public sealed record AsStringDateStringNullableGroup : IOperator
{
    public AsStringDateStringNullableGroup(DeclaresDateNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDateNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
