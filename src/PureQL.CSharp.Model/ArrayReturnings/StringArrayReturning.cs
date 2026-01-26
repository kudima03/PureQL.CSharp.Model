using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class StringArrayReturning
    : OneOfBase<StringArrayParameter, StringField, StringArrayScalar>
{
    public StringArrayReturning(StringArrayParameter parameter)
        : this((OneOf<StringArrayParameter, StringField, StringArrayScalar>)parameter) { }

    public StringArrayReturning(StringField field)
        : this((OneOf<StringArrayParameter, StringField, StringArrayScalar>)field) { }

    public StringArrayReturning(StringArrayScalar scalar)
        : this((OneOf<StringArrayParameter, StringField, StringArrayScalar>)scalar) { }

    private StringArrayReturning(
        OneOf<StringArrayParameter, StringField, StringArrayScalar> input
    )
        : base(input) { }
}
