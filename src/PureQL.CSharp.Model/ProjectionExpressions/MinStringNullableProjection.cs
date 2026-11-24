using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.string.nullable@projection</c>.</summary>
public sealed record MinStringNullableProjection : IOperator
{
    public MinStringNullableProjection(
        StringNullableRow selector,
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

    public StringNullableRow Selector { get; }

    public IType Type => new TypeStringNullable();
}
