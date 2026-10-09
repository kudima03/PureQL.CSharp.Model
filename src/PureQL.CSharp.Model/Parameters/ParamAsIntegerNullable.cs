using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsIntegerNullable : OneOfBase<ParamInteger, ParamIntegerNullable>
{
    public ParamAsIntegerNullable(ParamInteger value)
        : this((OneOf<ParamInteger, ParamIntegerNullable>)value) { }

    public ParamAsIntegerNullable(ParamIntegerNullable value)
        : this((OneOf<ParamInteger, ParamIntegerNullable>)value) { }

    private ParamAsIntegerNullable(OneOf<ParamInteger, ParamIntegerNullable> input)
        : base(input) { }
}
