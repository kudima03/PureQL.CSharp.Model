using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>min.uuid.nullable@projection</c>.</summary>
public sealed record MinUuidNullableProjection : IOperator
{
    public MinUuidNullableProjection(
        UuidNullableRow selector,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public UuidNullableRow Selector { get; }

    public IType Type => new TypeUuidNullable();
}
