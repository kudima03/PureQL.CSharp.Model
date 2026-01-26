using OneOf;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class NumberReturning : OneOfBase<NumberParameter, NumberScalar>
{
    public NumberReturning(NumberParameter parameter)
        : this((OneOf<NumberParameter, NumberScalar>)parameter) { }

    public NumberReturning(NumberScalar scalar)
        : this((OneOf<NumberParameter, NumberScalar>)scalar) { }

    private NumberReturning(OneOf<NumberParameter, NumberScalar> input)
        : base(input) { }
}
