using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class UuidArrayReturning
    : OneOfBase<UuidArrayParameter, UuidField, UuidArrayScalar>
{
    public UuidArrayReturning(UuidArrayParameter parameter)
        : this((OneOf<UuidArrayParameter, UuidField, UuidArrayScalar>)parameter) { }

    public UuidArrayReturning(UuidField field)
        : this((OneOf<UuidArrayParameter, UuidField, UuidArrayScalar>)field) { }

    public UuidArrayReturning(UuidArrayScalar scalar)
        : this((OneOf<UuidArrayParameter, UuidField, UuidArrayScalar>)scalar) { }

    private UuidArrayReturning(
        OneOf<UuidArrayParameter, UuidField, UuidArrayScalar> input
    )
        : base(input) { }
}
