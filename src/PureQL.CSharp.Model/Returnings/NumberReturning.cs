using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class NumberReturning
    : OneOfBase<NumberField, NumberParameter, NumberScalar>
{
    public NumberReturning(NumberField field)
        : this((OneOf<NumberField, NumberParameter, NumberScalar>)field) { }

    public NumberReturning(NumberParameter parameter)
        : this((OneOf<NumberField, NumberParameter, NumberScalar>)parameter) { }

    public NumberReturning(NumberScalar scalar)
        : this((OneOf<NumberField, NumberParameter, NumberScalar>)scalar) { }

    private NumberReturning(OneOf<NumberField, NumberParameter, NumberScalar> input)
        : base(input) { }
}
