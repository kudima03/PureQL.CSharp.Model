using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>if.string.nullable@projection</c>.</summary>
public sealed record IfStringNullableProjection : IOperator
{
    public IfStringNullableProjection(
        StringNullableProjection then,
        StringNullableProjection @else,
        BooleanProjection condition
    )
    {
        Then = then;
        Else = @else;
        Condition = condition;
    }

    public StringNullableProjection Then { get; }

    public StringNullableProjection Else { get; }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeStringNullable();
}
