using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceStringProjection : IOperator
{
    public CoalesceStringProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }

    public IType Type => new TypeString();
}
