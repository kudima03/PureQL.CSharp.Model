using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.string@projection</c>.</summary>
public sealed record LeastStringProjection : IOperator
{
    public LeastStringProjection(IEnumerable<StringProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringProjection> Values { get; }

    public IType Type => new TypeString();
}
