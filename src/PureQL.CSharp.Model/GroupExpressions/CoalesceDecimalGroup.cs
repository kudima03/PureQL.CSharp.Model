using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record CoalesceDecimalGroup : IOperator
{
    public CoalesceDecimalGroup(IEnumerable<DecimalNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableGroup> Values { get; }

    public IType Type => new TypeDecimal();
}
