using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>concatWith@row</c>.</summary>
public sealed record ConcatWithRow : IOperator
{
    public ConcatWithRow(IEnumerable<StringNullableRow> values, StringRow separator)
    {
        Values = values;
        Separator = separator;
    }

    public IEnumerable<StringNullableRow> Values { get; }

    public StringRow Separator { get; }

    public IType Type => new TypeString();
}
