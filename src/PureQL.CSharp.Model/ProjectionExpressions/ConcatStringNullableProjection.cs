using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record ConcatStringNullableProjection : IOperator
{
    public ConcatStringNullableProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }

    public IType Type => new TypeStringNullable();
}
