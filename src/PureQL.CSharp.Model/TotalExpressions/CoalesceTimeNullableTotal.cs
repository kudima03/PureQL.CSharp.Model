using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceTimeNullableTotal : IOperator
{
    public CoalesceTimeNullableTotal(IEnumerable<TimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableTotal> Values { get; }

    public IType Type => new TypeTimeNullable();
}
