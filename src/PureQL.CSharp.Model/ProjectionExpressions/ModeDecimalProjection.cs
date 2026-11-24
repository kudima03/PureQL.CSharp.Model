using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.decimal@projection</c>.</summary>
public sealed record ModeDecimalProjection : IOperator
{
    public ModeDecimalProjection(DeclaresDecimalRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DeclaresDecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
