using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>regressionIntercept@group</c>.</summary>
public sealed record RegressionInterceptGroup : IOperator
{
    public RegressionInterceptGroup(
        DecimalNullableRow y,
        DecimalNullableRow x,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Y = y;
        X = x;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public DecimalNullableRow Y { get; }

    public DecimalNullableRow X { get; }

    public IType Type => new TypeDecimalNullable();
}
