using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDecimalNullableProjection : IOperator
{
    public IfDecimalNullableProjection(
        BooleanProjection condition,
        DecimalNullableProjection then,
        DecimalNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DecimalNullableProjection Then { get; }

    public DecimalNullableProjection Else { get; }

    public IType Type => new TypeDecimalNullable();
}
