using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class UuidReturning : OneOfBase<UuidField, UuidParameter, UuidScalar>
{
    public UuidReturning(UuidField field)
        : this((OneOf<UuidField, UuidParameter, UuidScalar>)field) { }

    public UuidReturning(UuidParameter parameter)
        : this((OneOf<UuidField, UuidParameter, UuidScalar>)parameter) { }

    public UuidReturning(UuidScalar scalar)
        : this((OneOf<UuidField, UuidParameter, UuidScalar>)scalar) { }

    private UuidReturning(OneOf<UuidField, UuidParameter, UuidScalar> input)
        : base(input) { }
}
