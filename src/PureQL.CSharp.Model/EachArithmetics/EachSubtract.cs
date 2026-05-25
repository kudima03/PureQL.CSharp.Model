using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachArithmetics;

public sealed record EachSubtract
{
    public EachSubtract(IEnumerable<OneOf<NumberReturning, NumberArrayReturning>> values)
    {
        Values = values;
    }

    public IEnumerable<OneOf<NumberReturning, NumberArrayReturning>> Values { get; }
}
