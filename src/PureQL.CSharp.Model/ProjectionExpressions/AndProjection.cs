using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AndProjection : IOperator
{
    public AndProjection(IEnumerable<BooleanProjection> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanProjection> Conditions { get; }

    public IType Type => new TypeBoolean();
}
