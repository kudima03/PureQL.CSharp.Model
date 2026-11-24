using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.time.nullable@total</c>.</summary>
public sealed record GreatestTimeNullableTotal : IOperator
{
    public GreatestTimeNullableTotal(IEnumerable<TimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableTotal> Values { get; }

    public IType Type => new TypeTimeNullable();
}
