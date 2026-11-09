using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.date.nullable@total</c>.</summary>
public sealed record CoalesceDateNullableTotal : IOperator
{
    public CoalesceDateNullableTotal(IEnumerable<DeclaresDateNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresDateNullableTotal> Values { get; }

    public IType Type => new TypeDateNullable();
}
