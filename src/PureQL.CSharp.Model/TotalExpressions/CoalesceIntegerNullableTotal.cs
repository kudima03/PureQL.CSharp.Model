using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.integer.nullable@total</c>.</summary>
public sealed record CoalesceIntegerNullableTotal : IOperator
{
    public CoalesceIntegerNullableTotal(IEnumerable<DeclaresIntegerNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresIntegerNullableTotal> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
