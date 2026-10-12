using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record ConcatStringProjection : IOperator
{
    public ConcatStringProjection(IEnumerable<StringProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringProjection> Values { get; }

    public IType Type => new TypeString();
}
