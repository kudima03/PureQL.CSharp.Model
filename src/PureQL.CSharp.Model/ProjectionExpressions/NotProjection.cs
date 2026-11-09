using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>not@projection</c>.</summary>
public sealed record NotProjection : IOperator
{
    public NotProjection(BooleanProjection condition)
    {
        Condition = condition;
    }

    public BooleanProjection Condition { get; }

    public IType Type => new TypeBoolean();
}
