using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.decimal.nullable@projection</c>.</summary>
public sealed record IfDecimalNullableProjection : IOperator
{
    public IfDecimalNullableProjection(
        DecimalNullableProjection then,
        DecimalNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalNullableProjection Then { get; }

    public DecimalNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeDecimalNullable();
}
