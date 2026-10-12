using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record FloorIntegerNullableProjection : IOperator
{
    public FloorIntegerNullableProjection(DecimalNullableProjection operand)
    {
        Operand = operand;
    }

    public DecimalNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
