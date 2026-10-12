using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDecimalProjection : IOperator
{
    public CoalesceDecimalProjection(IEnumerable<DecimalNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }

    public IType Type => new TypeDecimal();
}
