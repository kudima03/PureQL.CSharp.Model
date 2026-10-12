using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinIntegerNullableProjection : IOperator
{
    public MinIntegerNullableProjection(
        IntegerNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public IntegerNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeIntegerNullable();
}
