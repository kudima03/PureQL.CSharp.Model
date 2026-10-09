using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralDate : ILiteral
{
    public ListLiteralDate(IEnumerable<DateOnly> value)
    {
        Value = value;
    }

    public IEnumerable<DateOnly> Value { get; }

    public IType Type => new TypeDateList();
}
