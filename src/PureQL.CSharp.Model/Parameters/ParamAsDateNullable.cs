using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsDateNullable : OneOfBase<ParamDate, ParamDateNullable>
{
    public ParamAsDateNullable(ParamDate value)
        : this((OneOf<ParamDate, ParamDateNullable>)value) { }

    public ParamAsDateNullable(ParamDateNullable value)
        : this((OneOf<ParamDate, ParamDateNullable>)value) { }

    private ParamAsDateNullable(OneOf<ParamDate, ParamDateNullable> input)
        : base(input) { }
}
