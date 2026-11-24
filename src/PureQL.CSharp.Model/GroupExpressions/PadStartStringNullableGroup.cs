using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>padStart.string.nullable@group</c>.</summary>
public sealed record PadStartStringNullableGroup : IOperator
{
    public PadStartStringNullableGroup(
        StringNullableGroup operand,
        IntegerNullableGroup length,
        StringNullableGroup fill
    )
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringNullableGroup Operand { get; }

    public IntegerNullableGroup Length { get; }

    public StringNullableGroup Fill { get; }

    public IType Type => new TypeStringNullable();
}
