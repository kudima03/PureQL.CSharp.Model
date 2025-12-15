using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Arithmetics;

public sealed record Divide
{
    public Divide(IEnumerable<NumberReturning> arguments)
    {
        Arguments = arguments;
    }

    public IEnumerable<NumberReturning> Arguments { get; }
}
