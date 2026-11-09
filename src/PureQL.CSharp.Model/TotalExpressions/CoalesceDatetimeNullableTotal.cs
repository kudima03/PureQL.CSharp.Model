using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.datetime.nullable@total</c>.</summary>
public sealed record CoalesceDatetimeNullableTotal : IOperator
{
    public CoalesceDatetimeNullableTotal(
        IEnumerable<DeclaresDatetimeNullableTotal> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresDatetimeNullableTotal> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
