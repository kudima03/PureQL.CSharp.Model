using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>greatest.decimal@total</c>.</summary>
public sealed record GreatestDecimalTotal : IOperator
{
    public GreatestDecimalTotal(IEnumerable<DecimalTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalTotal> Values { get; }

    public IType Type => new TypeDecimal();
}
