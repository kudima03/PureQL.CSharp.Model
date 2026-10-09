using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsUuidNullable : OneOfBase<ParamUuid, ParamUuidNullable>
{
    public ParamAsUuidNullable(ParamUuid value)
        : this((OneOf<ParamUuid, ParamUuidNullable>)value) { }

    public ParamAsUuidNullable(ParamUuidNullable value)
        : this((OneOf<ParamUuid, ParamUuidNullable>)value) { }

    private ParamAsUuidNullable(OneOf<ParamUuid, ParamUuidNullable> input)
        : base(input) { }
}
