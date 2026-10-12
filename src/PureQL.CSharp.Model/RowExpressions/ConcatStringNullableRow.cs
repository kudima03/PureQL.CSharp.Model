using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record ConcatStringNullableRow : IOperator
{
    public ConcatStringNullableRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }

    public IType Type => new TypeStringNullable();
}
