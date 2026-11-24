using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.integer@projection</c>.</summary>
public sealed record ModeIntegerProjection : IOperator
{
    public ModeIntegerProjection(IntegerRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public IntegerRow Selector { get; }

    public IType Type => new TypeInteger();
}
