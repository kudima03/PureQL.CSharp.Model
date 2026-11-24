using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>floor.integer.nullable@projection</c>.</summary>
public sealed record FloorIntegerNullableProjection : IOperator
{
    public FloorIntegerNullableProjection(DeclaresDecimalNullableProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
