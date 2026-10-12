using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceStringRow : IOperator
{
    public CoalesceStringRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }

    public IType Type => new TypeString();
}
