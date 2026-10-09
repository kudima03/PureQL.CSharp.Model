using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsBooleanNullable : OneOfBase<ParamBoolean, ParamBooleanNullable>
{
    public ParamAsBooleanNullable(ParamBoolean value)
        : this((OneOf<ParamBoolean, ParamBooleanNullable>)value) { }

    public ParamAsBooleanNullable(ParamBooleanNullable value)
        : this((OneOf<ParamBoolean, ParamBooleanNullable>)value) { }

    private ParamAsBooleanNullable(OneOf<ParamBoolean, ParamBooleanNullable> input)
        : base(input) { }
}
