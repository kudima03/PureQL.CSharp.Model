using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class BooleanReturning
    : OneOfBase<BooleanField, BooleanParameter, BooleanScalar>
{
    public BooleanReturning(BooleanField field)
        : this((OneOf<BooleanField, BooleanParameter, BooleanScalar>)field) { }

    public BooleanReturning(BooleanParameter parameter)
        : this((OneOf<BooleanField, BooleanParameter, BooleanScalar>)parameter) { }

    public BooleanReturning(BooleanScalar scalar)
        : this((OneOf<BooleanField, BooleanParameter, BooleanScalar>)scalar) { }

    private BooleanReturning(OneOf<BooleanField, BooleanParameter, BooleanScalar> input)
        : base(input) { }
}
