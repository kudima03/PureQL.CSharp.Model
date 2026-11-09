using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>concat.string.nullable@row</c>.</summary>
public sealed record ConcatStringNullableRow : IOperator
{
    public ConcatStringNullableRow(IEnumerable<StringNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableRow> Values { get; }

    public IType Type => new TypeStringNullable();
}
