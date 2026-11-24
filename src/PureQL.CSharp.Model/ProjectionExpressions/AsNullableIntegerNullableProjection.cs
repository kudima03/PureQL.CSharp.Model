using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.integer.nullable@projection</c>.</summary>
public sealed record AsNullableIntegerNullableProjection : IOperator
{
    public AsNullableIntegerNullableProjection(IntegerProjection operand)
    {
        Operand = operand;
    }

    public IntegerProjection Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
