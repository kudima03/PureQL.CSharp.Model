using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>ntile@projection</c>.</summary>
public sealed record NtileProjection : IOperator
{
    public NtileProjection(Buckets buckets, OrderedWindow over)
    {
        Buckets = buckets;
        Over = over;
    }

    public Buckets Buckets { get; }

    public OrderedWindow Over { get; }

    public IType Type => new TypeInteger();
}
