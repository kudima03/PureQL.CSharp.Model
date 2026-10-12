using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfDecimalProjection : IOperator
{
    public IfDecimalProjection(
        BooleanProjection condition,
        DecimalProjection then,
        DecimalProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public DecimalProjection Then { get; }

    public DecimalProjection Else { get; }

    public IType Type => new TypeDecimal();
}
