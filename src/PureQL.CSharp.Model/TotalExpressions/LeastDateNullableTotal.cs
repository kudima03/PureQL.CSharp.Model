using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.date.nullable@total</c>.</summary>
public sealed record LeastDateNullableTotal : IOperator
{
    public LeastDateNullableTotal(IEnumerable<DateNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableTotal> Values { get; }

    public IType Type => new TypeDateNullable();
}
