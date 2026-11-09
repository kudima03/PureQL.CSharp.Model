using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.integer@projection</c>.</summary>
public sealed record MaxIntegerProjection : IOperator
{
    public MaxIntegerProjection(IntegerRow selector)
    {
        Selector = selector;
    }

    public IntegerRow Selector { get; }

    public IType Type => new TypeInteger();
}
