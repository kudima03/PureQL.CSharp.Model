using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.string.nullable@total</c>.</summary>
public sealed record LeastStringNullableTotal : IOperator
{
    public LeastStringNullableTotal(IEnumerable<StringNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableTotal> Values { get; }

    public IType Type => new TypeStringNullable();
}
