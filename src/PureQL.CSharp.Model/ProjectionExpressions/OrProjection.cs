using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record OrProjection : IOperator
{
    public OrProjection(IEnumerable<BooleanProjection> conditions)
    {
        Conditions = conditions;
    }

    public IEnumerable<BooleanProjection> Conditions { get; }

    public IType Type => new TypeBoolean();
}
