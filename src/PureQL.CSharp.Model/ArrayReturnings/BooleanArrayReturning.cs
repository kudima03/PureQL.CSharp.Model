using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class BooleanArrayReturning
    : OneOfBase<BooleanArrayScalar, BooleanField, BooleanArrayParameter>
{
    public BooleanArrayReturning(BooleanArrayScalar scalar)
        : this((OneOf<BooleanArrayScalar, BooleanField, BooleanArrayParameter>)scalar) { }

    public BooleanArrayReturning(BooleanField field)
        : this((OneOf<BooleanArrayScalar, BooleanField, BooleanArrayParameter>)field) { }

    public BooleanArrayReturning(BooleanArrayParameter parameter)
        : this((OneOf<BooleanArrayScalar, BooleanField, BooleanArrayParameter>)parameter)
    { }

    private BooleanArrayReturning(
        OneOf<BooleanArrayScalar, BooleanField, BooleanArrayParameter> input
    )
        : base(input) { }
}
