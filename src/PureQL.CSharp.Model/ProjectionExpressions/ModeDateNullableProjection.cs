using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.date.nullable@projection</c>.</summary>
public sealed record ModeDateNullableProjection : IOperator
{
    public ModeDateNullableProjection(
        DateNullableRow selector,
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

    public DateNullableRow Selector { get; }

    public IType Type => new TypeDateNullable();
}
