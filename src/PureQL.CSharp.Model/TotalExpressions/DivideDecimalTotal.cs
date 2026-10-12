using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record DivideDecimalTotal : IOperator
{
    public DivideDecimalTotal(IEnumerable<DecimalTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalTotal> Values { get; }

    public IType Type => new TypeDecimal();
}
