using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.boolean.nullable@total</c>.</summary>
public sealed record CoalesceBooleanNullableTotal : IOperator
{
    public CoalesceBooleanNullableTotal(IEnumerable<DeclaresBooleanNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresBooleanNullableTotal> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
