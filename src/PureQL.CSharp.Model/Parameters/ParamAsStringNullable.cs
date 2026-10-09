using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsStringNullable : OneOfBase<ParamString, ParamStringNullable>
{
    public ParamAsStringNullable(ParamString value)
        : this((OneOf<ParamString, ParamStringNullable>)value) { }

    public ParamAsStringNullable(ParamStringNullable value)
        : this((OneOf<ParamString, ParamStringNullable>)value) { }

    private ParamAsStringNullable(OneOf<ParamString, ParamStringNullable> input)
        : base(input) { }
}
