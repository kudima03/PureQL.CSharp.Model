using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MultiplyDecimalNullableProjection : IOperator
{
    public MultiplyDecimalNullableProjection(
        IEnumerable<DecimalNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
