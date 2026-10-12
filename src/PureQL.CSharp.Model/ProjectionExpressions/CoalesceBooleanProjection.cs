using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceBooleanProjection : IOperator
{
    public CoalesceBooleanProjection(IEnumerable<BooleanNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableProjection> Values { get; }

    public IType Type => new TypeBoolean();
}
