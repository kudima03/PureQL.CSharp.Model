using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>foldCase.string.nullable@group</c>.</summary>
public sealed record FoldCaseStringNullableGroup : IOperator
{
    public FoldCaseStringNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
