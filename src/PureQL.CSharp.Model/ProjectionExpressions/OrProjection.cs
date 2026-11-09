using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>or@projection</c>.</summary>
public sealed record OrProjection : IOperator
{
    public OrProjection(IEnumerable<BooleanProjection> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanProjection> Conditions { get; }

    public IType Type => new TypeBoolean();
}
