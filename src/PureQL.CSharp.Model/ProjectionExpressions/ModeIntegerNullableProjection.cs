using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>mode.integer.nullable@projection</c>.</summary>
public sealed record ModeIntegerNullableProjection : IOperator
{
    public ModeIntegerNullableProjection(
        IntegerNullableRow selector,
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

    public IntegerNullableRow Selector { get; }

    public IType Type => new TypeIntegerNullable();
}
