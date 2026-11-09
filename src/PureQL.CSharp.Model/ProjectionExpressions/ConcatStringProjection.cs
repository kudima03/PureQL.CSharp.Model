using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>concat.string@projection</c>.</summary>
public sealed record ConcatStringProjection : IOperator
{
    public ConcatStringProjection(IEnumerable<StringProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringProjection> Values { get; }

    public IType Type => new TypeString();
}
