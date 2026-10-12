using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CeilingIntegerNullableProjection : IOperator
{
    public CeilingIntegerNullableProjection(DecimalNullableProjection operand)
    {
        Operand = operand;
    }

    public DecimalNullableProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
