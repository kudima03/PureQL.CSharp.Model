using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.uuid@total</c>.</summary>
public sealed record GreatestUuidTotal : IOperator
{
    public GreatestUuidTotal(IEnumerable<UuidTotal> values)
    {
        Values = values;
    }

    public IEnumerable<UuidTotal> Values { get; }

    public IType Type => new TypeUuid();
}
