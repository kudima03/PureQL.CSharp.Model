using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>least.decimal.nullable@group</c>.</summary>
public sealed record LeastDecimalNullableGroup : IOperator
{
    public LeastDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
