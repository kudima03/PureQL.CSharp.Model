using OneOf;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class StringReturning : OneOfBase<StringParameter, StringScalar>
{
    public StringReturning(StringParameter parameter)
        : this((OneOf<StringParameter, StringScalar>)parameter) { }

    public StringReturning(StringScalar scalar)
        : this((OneOf<StringParameter, StringScalar>)scalar) { }

    private StringReturning(OneOf<StringParameter, StringScalar> input)
        : base(input) { }
}
