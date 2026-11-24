using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.time.nullable@projection</c>.</summary>
public sealed record ModeTimeNullableProjection : IOperator
{
    public ModeTimeNullableProjection(
        TimeNullableRow selector,
        BooleanRow? predicate = null,
        Window? over = null
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public Window? Over { get; }

    public TimeNullableRow Selector { get; }

    public IType Type => new TypeTimeNullable();
}
