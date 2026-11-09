using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>and@projection</c>.</summary>
public sealed record AndProjection : IOperator
{
    public AndProjection(IEnumerable<BooleanProjection> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanProjection> Conditions { get; }

    public IType Type => new TypeBoolean();
}
