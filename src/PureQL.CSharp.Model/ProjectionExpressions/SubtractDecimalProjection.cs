using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>subtract.decimal@projection</c>.</summary>
public sealed record SubtractDecimalProjection : IOperator
{
    public SubtractDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }

    public IType Type => new TypeDecimal();
}
