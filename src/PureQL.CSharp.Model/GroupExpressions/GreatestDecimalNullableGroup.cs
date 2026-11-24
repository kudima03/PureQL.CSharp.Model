using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>greatest.decimal.nullable@group</c>.</summary>
public sealed record GreatestDecimalNullableGroup : IOperator
{
    public GreatestDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
