using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>least.decimal@total</c>.</summary>
public sealed record LeastDecimalTotal : IOperator
{
    public LeastDecimalTotal(IEnumerable<DecimalTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalTotal> Values { get; }

    public IType Type => new TypeDecimal();
}
