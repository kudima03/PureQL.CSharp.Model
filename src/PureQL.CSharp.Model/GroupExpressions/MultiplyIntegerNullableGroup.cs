using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>multiply.integer.nullable@group</c>.</summary>
public sealed record MultiplyIntegerNullableGroup : IOperator
{
    public MultiplyIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
