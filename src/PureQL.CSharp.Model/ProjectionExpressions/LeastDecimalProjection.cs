using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.decimal@projection</c>.</summary>
public sealed record LeastDecimalProjection : IOperator
{
    public LeastDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }

    public IType Type => new TypeDecimal();
}
