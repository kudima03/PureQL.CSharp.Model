using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.boolean.nullable@group</c>.</summary>
public sealed record CoalesceBooleanNullableGroup : IOperator
{
    public CoalesceBooleanNullableGroup(IEnumerable<DeclaresBooleanNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresBooleanNullableGroup> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
