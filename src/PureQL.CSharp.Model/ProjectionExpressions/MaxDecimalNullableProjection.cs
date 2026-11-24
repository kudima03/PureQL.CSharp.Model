using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>max.decimal.nullable@projection</c>.</summary>
public sealed record MaxDecimalNullableProjection : IOperator
{
    public MaxDecimalNullableProjection(
        DecimalOrDecimalNullableRow selector,
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

    public DecimalOrDecimalNullableRow Selector { get; }

    public IType Type => new TypeDecimalNullable();
}
