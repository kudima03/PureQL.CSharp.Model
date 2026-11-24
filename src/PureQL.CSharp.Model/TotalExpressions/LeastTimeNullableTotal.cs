using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.time.nullable@total</c>.</summary>
public sealed record LeastTimeNullableTotal : IOperator
{
    public LeastTimeNullableTotal(IEnumerable<TimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableTotal> Values { get; }

    public IType Type => new TypeTimeNullable();
}
