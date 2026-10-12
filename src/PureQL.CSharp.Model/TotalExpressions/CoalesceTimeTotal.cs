using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceTimeTotal : IOperator
{
    public CoalesceTimeTotal(IEnumerable<TimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableTotal> Values { get; }

    public IType Type => new TypeTime();
}
