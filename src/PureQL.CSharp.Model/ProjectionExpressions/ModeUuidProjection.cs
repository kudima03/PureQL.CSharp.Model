using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.uuid@projection</c>.</summary>
public sealed record ModeUuidProjection : IOperator
{
    public ModeUuidProjection(UuidRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public UuidRow Selector { get; }

    public IType Type => new TypeUuid();
}
