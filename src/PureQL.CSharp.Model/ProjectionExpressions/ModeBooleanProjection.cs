using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.boolean@projection</c>.</summary>
public sealed record ModeBooleanProjection : IOperator
{
    public ModeBooleanProjection(BooleanRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public BooleanRow Selector { get; }

    public IType Type => new TypeBoolean();
}
