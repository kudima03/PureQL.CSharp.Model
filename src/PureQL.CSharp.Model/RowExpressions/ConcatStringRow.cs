using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record ConcatStringRow : IOperator
{
    public ConcatStringRow(IEnumerable<StringRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringRow> Values { get; }

    public IType Type => new TypeString();
}
