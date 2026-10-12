using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record AddDecimalNullableProjection : IOperator
{
    public AddDecimalNullableProjection(IEnumerable<DecimalNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
