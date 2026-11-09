using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.decimal@projection</c>.</summary>
public sealed record IfDecimalProjection : IOperator
{
    public IfDecimalProjection(
        DecimalProjection then,
        DecimalProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public DecimalProjection Then { get; }

    public DecimalProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeDecimal();
}
