using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.string.nullable@total</c>.</summary>
public sealed record CoalesceStringNullableTotal : IOperator
{
    public CoalesceStringNullableTotal(IEnumerable<DeclaresStringNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresStringNullableTotal> Values { get; }

    public IType Type => new TypeStringNullable();
}
