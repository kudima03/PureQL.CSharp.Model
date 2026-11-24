using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.boolean@total</c>.</summary>
public sealed record LeastBooleanTotal : IOperator
{
    public LeastBooleanTotal(IEnumerable<BooleanTotal> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanTotal> Values { get; }

    public IType Type => new TypeBoolean();
}
