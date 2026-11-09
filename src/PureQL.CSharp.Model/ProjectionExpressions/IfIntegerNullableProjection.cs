using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.integer.nullable@projection</c>.</summary>
public sealed record IfIntegerNullableProjection : IOperator
{
    public IfIntegerNullableProjection(
        IntegerNullableProjection then,
        IntegerNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public IntegerNullableProjection Then { get; }

    public IntegerNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeIntegerNullable();
}
