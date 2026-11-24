using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>average.time.nullable@projection</c>.</summary>
public sealed record AverageTimeNullableProjection : IOperator
{
    public AverageTimeNullableProjection(
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
