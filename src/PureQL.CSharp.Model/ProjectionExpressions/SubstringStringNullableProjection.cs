using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>substring.string.nullable@projection</c>.</summary>
public sealed record SubstringStringNullableProjection : IOperator
{
    public SubstringStringNullableProjection(
        StringNullableProjection operand,
        IntegerNullableProjection start,
        IntegerNullableProjection? length = null
    )
    {
        Operand = operand;
        Start = start;
        Length = length;
    }

    public StringNullableProjection Operand { get; }

    public IntegerNullableProjection Start { get; }

    public IntegerNullableProjection? Length { get; }

    public IType Type => new TypeStringNullable();
}
