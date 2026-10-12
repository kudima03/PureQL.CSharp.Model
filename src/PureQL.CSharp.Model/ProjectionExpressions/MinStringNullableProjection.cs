using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record MinStringNullableProjection : IOperator
{
    public MinStringNullableProjection(
        StringNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Selector = selector;
        Predicate = predicate;
    }

    public StringNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeStringNullable();
}
