using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.string.nullable@total</c>.</summary>
public sealed record GreatestStringNullableTotal : IOperator
{
    public GreatestStringNullableTotal(IEnumerable<StringNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableTotal> Values { get; }

    public IType Type => new TypeStringNullable();
}
