using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.integer@projection</c>.</summary>
public sealed record MinIntegerProjection : IOperator
{
    public MinIntegerProjection(IntegerRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public IntegerRow Selector { get; }

    public IType Type => new TypeInteger();
}
