using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record IfStringNullableProjection : IOperator
{
    public IfStringNullableProjection(
        BooleanProjection condition,
        StringNullableProjection then,
        StringNullableProjection @else
    )
    {
        Condition = condition;
        Then = then;
        Else = @else;
    }

    public BooleanProjection Condition { get; }

    public StringNullableProjection Then { get; }

    public StringNullableProjection Else { get; }

    public IType Type => new TypeStringNullable();
}
