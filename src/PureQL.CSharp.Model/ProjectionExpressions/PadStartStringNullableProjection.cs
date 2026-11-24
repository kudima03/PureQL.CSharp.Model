using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>padStart.string.nullable@projection</c>.</summary>
public sealed record PadStartStringNullableProjection : IOperator
{
    public PadStartStringNullableProjection(
        StringNullableProjection operand,
        IntegerNullableProjection length,
        StringNullableProjection fill
    )
    {
        Operand = operand;
        Length = length;
        Fill = fill;
    }

    public StringNullableProjection Operand { get; }

    public IntegerNullableProjection Length { get; }

    public StringNullableProjection Fill { get; }

    public IType Type => new TypeStringNullable();
}
