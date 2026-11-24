using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.datetime@total</c>.</summary>
public sealed record LeastDatetimeTotal : IOperator
{
    public LeastDatetimeTotal(IEnumerable<DatetimeTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeTotal> Values { get; }

    public IType Type => new TypeDatetime();
}
