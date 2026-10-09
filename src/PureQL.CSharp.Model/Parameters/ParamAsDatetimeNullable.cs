using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsDatetimeNullable
    : OneOfBase<ParamDatetime, ParamDatetimeNullable>
{
    public ParamAsDatetimeNullable(ParamDatetime value)
        : this((OneOf<ParamDatetime, ParamDatetimeNullable>)value) { }

    public ParamAsDatetimeNullable(ParamDatetimeNullable value)
        : this((OneOf<ParamDatetime, ParamDatetimeNullable>)value) { }

    private ParamAsDatetimeNullable(OneOf<ParamDatetime, ParamDatetimeNullable> input)
        : base(input) { }
}
