using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.decimal.nullable@projection</c>.</summary>
public sealed record AsNullableDecimalNullableProjection : IOperator
{
    public AsNullableDecimalNullableProjection(DeclaresDecimalProjection operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
