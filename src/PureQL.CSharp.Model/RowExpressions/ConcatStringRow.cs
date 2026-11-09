using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>concat.string@row</c>.</summary>
public sealed record ConcatStringRow : IOperator
{
    public ConcatStringRow(IEnumerable<StringRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringRow> Values { get; }

    public IType Type => new TypeString();
}
