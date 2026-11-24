using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>padEnd.string.nullable@group</c>.</summary>
public sealed record PadEndStringNullableGroup : IOperator
{
    public PadEndStringNullableGroup(
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
