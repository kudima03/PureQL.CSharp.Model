using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>repeat.string.nullable@projection</c>.</summary>
public sealed record RepeatStringNullableProjection : IOperator
{
    public RepeatStringNullableProjection(
        StringNullableProjection operand,
        IntegerNullableProjection count
    )
    {
        Operand = operand;
        Count = count;
    }

    public StringNullableProjection Operand { get; }

    public IntegerNullableProjection Count { get; }

    public IType Type => new TypeStringNullable();
}
