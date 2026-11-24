using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>rowNumber@projection</c>.</summary>
public sealed record RowNumberProjection : IOperator
{
    public RowNumberProjection(OrderedWindow over)
    {
        Over = over;
    }

    public OrderedWindow Over { get; }

    public IType Type => new TypeInteger();
}
