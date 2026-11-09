using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.time@total</c>.</summary>
public sealed record CoalesceTimeTotal : IOperator
{
    public CoalesceTimeTotal(IEnumerable<TimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableTotal> Values { get; }

    public IType Type => new TypeTime();
}
