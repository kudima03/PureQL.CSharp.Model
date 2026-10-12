using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record AddDecimalNullableTotal : IOperator
{
    public AddDecimalNullableTotal(IEnumerable<DecimalNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableTotal> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
