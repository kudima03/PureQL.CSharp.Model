using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.time@total</c>.</summary>
public sealed record GreatestTimeTotal : IOperator
{
    public GreatestTimeTotal(IEnumerable<TimeTotal> values)
    {
        Values = values;
    }

    public IEnumerable<TimeTotal> Values { get; }

    public IType Type => new TypeTime();
}
