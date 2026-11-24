using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>splitPart.string.nullable@projection</c>.</summary>
public sealed record SplitPartStringNullableProjection : IOperator
{
    public SplitPartStringNullableProjection(
        StringNullableProjection operand,
        StringNullableProjection delimiter,
        IntegerNullableProjection index
    )
    {
        Operand = operand;
        Delimiter = delimiter;
        Index = index;
    }

    public StringNullableProjection Operand { get; }

    public StringNullableProjection Delimiter { get; }

    public IntegerNullableProjection Index { get; }

    public IType Type => new TypeStringNullable();
}
