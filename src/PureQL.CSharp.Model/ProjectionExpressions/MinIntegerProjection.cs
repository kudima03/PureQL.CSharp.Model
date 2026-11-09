using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.integer@projection</c>.</summary>
public sealed record MinIntegerProjection : IOperator
{
    public MinIntegerProjection(IntegerRow selector)
    {
        Selector = selector;
    }

    public IntegerRow Selector { get; }

    public IType Type => new TypeInteger();
}
