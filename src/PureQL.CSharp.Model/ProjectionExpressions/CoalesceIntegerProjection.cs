using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.integer@projection</c>.</summary>
public sealed record CoalesceIntegerProjection : IOperator
{
    public CoalesceIntegerProjection(IEnumerable<IntegerNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }

    public IType Type => new TypeInteger();
}
