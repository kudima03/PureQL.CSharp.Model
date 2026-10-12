using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AddIntegerNullableGroup : IOperator
{
    public AddIntegerNullableGroup(IEnumerable<IntegerNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableGroup> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
