using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>tryAsDecimal@projection</c>.</summary>
public sealed record TryAsDecimalProjection : IOperator
{
    public TryAsDecimalProjection(StringNullableProjection operand)
    {
        Operand = operand;
    }

    public StringNullableProjection Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
