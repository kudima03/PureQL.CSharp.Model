using OneOf;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class UuidReturning : OneOfBase<UuidParameter, UuidScalar>
{
    public UuidReturning(UuidParameter parameter)
        : this((OneOf<UuidParameter, UuidScalar>)parameter) { }

    public UuidReturning(UuidScalar scalar)
        : this((OneOf<UuidParameter, UuidScalar>)scalar) { }

    private UuidReturning(OneOf<UuidParameter, UuidScalar> input)
        : base(input) { }
}
