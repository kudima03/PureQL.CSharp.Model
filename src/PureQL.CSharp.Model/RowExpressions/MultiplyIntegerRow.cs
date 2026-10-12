using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record MultiplyIntegerRow : IOperator
{
    public MultiplyIntegerRow(IEnumerable<IntegerRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerRow> Values { get; }

    public IType Type => new TypeInteger();
}
