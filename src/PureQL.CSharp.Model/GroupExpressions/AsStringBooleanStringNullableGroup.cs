using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.boolean.string.nullable@group</c>.</summary>
public sealed record AsStringBooleanStringNullableGroup : IOperator
{
    public AsStringBooleanStringNullableGroup(DeclaresBooleanNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresBooleanNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
