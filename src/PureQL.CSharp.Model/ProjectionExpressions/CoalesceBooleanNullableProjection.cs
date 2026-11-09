using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.boolean.nullable@projection</c>.</summary>
public sealed record CoalesceBooleanNullableProjection : IOperator
{
    public CoalesceBooleanNullableProjection(
        IEnumerable<DeclaresBooleanNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresBooleanNullableProjection> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
