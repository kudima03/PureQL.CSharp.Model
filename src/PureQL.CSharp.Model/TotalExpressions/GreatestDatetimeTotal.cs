using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.datetime@total</c>.</summary>
public sealed record GreatestDatetimeTotal : IOperator
{
    public GreatestDatetimeTotal(IEnumerable<DatetimeTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeTotal> Values { get; }

    public IType Type => new TypeDatetime();
}
