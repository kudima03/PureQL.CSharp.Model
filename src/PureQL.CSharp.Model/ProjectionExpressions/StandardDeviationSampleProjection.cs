using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>standardDeviationSample@projection</c>.</summary>
public sealed record StandardDeviationSampleProjection : IOperator
{
    public StandardDeviationSampleProjection(
        DecimalNullableRow selector,
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

    public DecimalNullableRow Selector { get; }

    public IType Type => new TypeDecimalNullable();
}
