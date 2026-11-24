using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.decimal@projection</c>.</summary>
public sealed record MinDecimalProjection : IOperator
{
    public MinDecimalProjection(DeclaresDecimalRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DeclaresDecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
