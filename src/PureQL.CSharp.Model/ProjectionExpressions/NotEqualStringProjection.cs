using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>notEqual.string@projection</c>.</summary>
public sealed record NotEqualStringProjection : IOperator
{
    public NotEqualStringProjection(
        StringNullableProjection left,
        StringNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableProjection Left { get; }

    public StringNullableProjection Right { get; }

    public IType Type => new TypeBoolean();
}
