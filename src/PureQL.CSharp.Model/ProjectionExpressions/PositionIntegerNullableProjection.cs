using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>position.integer.nullable@projection</c>.</summary>
public sealed record PositionIntegerNullableProjection : IOperator
{
    public PositionIntegerNullableProjection(
        StringNullableProjection operand,
        StringNullableProjection pattern,
        IntegerNullableProjection? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringNullableProjection Operand { get; }

    public StringNullableProjection Pattern { get; }

    public IntegerNullableProjection? Start { get; }

    public IType Type => new TypeIntegerNullable();
}
