using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralDatetime : ILiteral
{
    public ListLiteralDatetime(IEnumerable<DateTimeOffset> value)
    {
        Value = value;
    }

    public IEnumerable<DateTimeOffset> Value { get; }

    public IType Type => new TypeDatetimeList();
}
