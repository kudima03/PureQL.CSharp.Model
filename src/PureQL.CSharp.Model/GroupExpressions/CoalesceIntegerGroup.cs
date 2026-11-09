using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.integer@group</c>.</summary>
public sealed record CoalesceIntegerGroup : IOperator
{
    public CoalesceIntegerGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }

    public IType Type => new TypeInteger();
}
