using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.decimal.nullable@group</c>.</summary>
public sealed record CoalesceDecimalNullableGroup : IOperator
{
    public CoalesceDecimalNullableGroup(
        IEnumerable<IntegerNullableOrDecimalNullableGroup> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableOrDecimalNullableGroup> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
