using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachArithmetics;

public sealed record EachMultiply
{
    public EachMultiply(IEnumerable<OneOf<NumberReturning, NumberArrayReturning>> values)
    {
        Values = values;
    }

    public IEnumerable<OneOf<NumberReturning, NumberArrayReturning>> Values { get; }
}
