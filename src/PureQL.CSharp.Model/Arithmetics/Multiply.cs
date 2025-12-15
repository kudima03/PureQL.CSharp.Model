using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Arithmetics;

public sealed record Multiply
{
    public Multiply(IEnumerable<NumberReturning> arguments)
    {
        Arguments = arguments;
    }

    public IEnumerable<NumberReturning> Arguments { get; }
}
