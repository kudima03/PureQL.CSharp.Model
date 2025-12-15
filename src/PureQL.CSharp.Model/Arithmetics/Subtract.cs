using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Arithmetics;

public sealed record Subtract
{
    public Subtract(IEnumerable<NumberReturning> arguments)
    {
        Arguments = arguments;
    }

    public IEnumerable<NumberReturning> Arguments { get; }
}
