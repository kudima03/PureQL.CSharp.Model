using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>multiply.decimal.nullable@group</c>.</summary>
public sealed record MultiplyDecimalNullableGroup : IOperator
{
    public MultiplyDecimalNullableGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
