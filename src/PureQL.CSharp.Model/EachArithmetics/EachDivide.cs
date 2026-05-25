using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.EachArithmetics;

public sealed record EachDivide
{
    public EachDivide(IEnumerable<OneOf<NumberReturning, NumberArrayReturning>> values)
    {
        Values = values;
    }

    public IEnumerable<OneOf<NumberReturning, NumberArrayReturning>> Values { get; }
}
