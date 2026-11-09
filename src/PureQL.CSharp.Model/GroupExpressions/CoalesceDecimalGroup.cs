using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>coalesce.decimal@group</c>.</summary>
public sealed record CoalesceDecimalGroup : IOperator
{
    public CoalesceDecimalGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }

    public IType Type => new TypeDecimal();
}
