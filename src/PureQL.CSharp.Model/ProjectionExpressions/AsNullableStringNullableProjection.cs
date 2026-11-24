using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>asNullable.string.nullable@projection</c>.</summary>
public sealed record AsNullableStringNullableProjection : IOperator
{
    public AsNullableStringNullableProjection(StringProjection operand)
    {
        Operand = operand;
    }

    public StringProjection Operand { get; }

    public IType Type => new TypeStringNullable();
}
