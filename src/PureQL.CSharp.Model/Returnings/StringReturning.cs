using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class StringReturning
    : OneOfBase<StringField, StringParameter, StringScalar>
{
    public StringReturning(StringField field)
        : this((OneOf<StringField, StringParameter, StringScalar>)field) { }

    public StringReturning(StringParameter parameter)
        : this((OneOf<StringField, StringParameter, StringScalar>)parameter) { }

    public StringReturning(StringScalar scalar)
        : this((OneOf<StringField, StringParameter, StringScalar>)scalar) { }

    private StringReturning(OneOf<StringField, StringParameter, StringScalar> input)
        : base(input) { }
}
