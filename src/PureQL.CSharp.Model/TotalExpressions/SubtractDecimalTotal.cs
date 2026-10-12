using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record SubtractDecimalTotal : IOperator
{
    public SubtractDecimalTotal(IEnumerable<DecimalTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalTotal> Values { get; }

    public IType Type => new TypeDecimal();
}
