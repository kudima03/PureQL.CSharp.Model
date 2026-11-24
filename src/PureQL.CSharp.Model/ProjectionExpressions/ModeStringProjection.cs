using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.string@projection</c>.</summary>
public sealed record ModeStringProjection : IOperator
{
    public ModeStringProjection(StringRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public StringRow Selector { get; }

    public IType Type => new TypeString();
}
