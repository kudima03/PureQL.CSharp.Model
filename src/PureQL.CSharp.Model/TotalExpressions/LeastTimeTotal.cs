using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.time@total</c>.</summary>
public sealed record LeastTimeTotal : IOperator
{
    public LeastTimeTotal(IEnumerable<TimeTotal> values)
    {
        Values = values;
    }

    public IEnumerable<TimeTotal> Values { get; }

    public IType Type => new TypeTime();
}
