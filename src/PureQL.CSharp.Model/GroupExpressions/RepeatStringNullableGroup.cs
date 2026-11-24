using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>repeat.string.nullable@group</c>.</summary>
public sealed record RepeatStringNullableGroup : IOperator
{
    public RepeatStringNullableGroup(
        StringNullableGroup operand,
        IntegerNullableGroup count
    )
    {
        Operand = operand;
        Count = count;
    }

    public StringNullableGroup Operand { get; }

    public IntegerNullableGroup Count { get; }

    public IType Type => new TypeStringNullable();
}
