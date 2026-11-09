using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>multiply.decimal@projection</c>.</summary>
public sealed record MultiplyDecimalProjection : IOperator
{
    public MultiplyDecimalProjection(IEnumerable<DecimalProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalProjection> Values { get; }

    public IType Type => new TypeDecimal();
}
