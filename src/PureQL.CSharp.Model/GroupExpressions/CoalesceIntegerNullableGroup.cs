using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.integer.nullable@group</c>.</summary>
public sealed record CoalesceIntegerNullableGroup : IOperator
{
    public CoalesceIntegerNullableGroup(IEnumerable<DeclaresIntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresIntegerNullableGroup> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
