using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer.nullable@projection</c>.</summary>
public sealed record MicrosecondDatetimeIntegerNullableProjection : IOperator
{
    public MicrosecondDatetimeIntegerNullableProjection(
        DeclaresDatetimeNullableProjection operand
    )
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
