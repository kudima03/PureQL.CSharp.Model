using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.decimal@projection</c>.</summary>
public sealed record GreatestDecimalProjection : IOperator
{
    public GreatestDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }

    public IType Type => new TypeDecimal();
}
