using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class NumberArrayReturning
    : OneOfBase<NumberArrayParameter, NumberField, NumberArrayScalar>
{
    public NumberArrayReturning(NumberArrayParameter parameter)
        : this((OneOf<NumberArrayParameter, NumberField, NumberArrayScalar>)parameter) { }

    public NumberArrayReturning(NumberField field)
        : this((OneOf<NumberArrayParameter, NumberField, NumberArrayScalar>)field) { }

    public NumberArrayReturning(NumberArrayScalar scalar)
        : this((OneOf<NumberArrayParameter, NumberField, NumberArrayScalar>)scalar) { }

    private NumberArrayReturning(
        OneOf<NumberArrayParameter, NumberField, NumberArrayScalar> input
    )
        : base(input) { }
}
