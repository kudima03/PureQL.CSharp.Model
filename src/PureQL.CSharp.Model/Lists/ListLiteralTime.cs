using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralTime : ILiteral
{
    public ListLiteralTime(IEnumerable<TimeOnly> value)
    {
        Value = value;
    }

    public IEnumerable<TimeOnly> Value { get; }

    public IType Type => new TypeTimeList();
}
