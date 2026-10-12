using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceStringNullableTotal : IOperator
{
    public CoalesceStringNullableTotal(IEnumerable<StringNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableTotal> Values { get; }

    public IType Type => new TypeStringNullable();
}
