using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.string@projection</c>.</summary>
public sealed record GreatestStringProjection : IOperator
{
    public GreatestStringProjection(IEnumerable<StringProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringProjection> Values { get; }

    public IType Type => new TypeString();
}
