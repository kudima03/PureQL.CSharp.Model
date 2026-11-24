using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.uuid@total</c>.</summary>
public sealed record LeastUuidTotal : IOperator
{
    public LeastUuidTotal(IEnumerable<UuidTotal> values)
    {
        Values = values;
    }

    public IEnumerable<UuidTotal> Values { get; }

    public IType Type => new TypeUuid();
}
