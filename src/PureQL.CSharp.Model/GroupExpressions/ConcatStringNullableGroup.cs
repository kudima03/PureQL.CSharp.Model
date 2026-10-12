using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record ConcatStringNullableGroup : IOperator
{
    public ConcatStringNullableGroup(IEnumerable<StringNullableGroup> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableGroup> Values { get; }

    public IType Type => new TypeStringNullable();
}
