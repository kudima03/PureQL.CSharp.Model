using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsTimeNullable : OneOfBase<ParamTime, ParamTimeNullable>
{
    public ParamAsTimeNullable(ParamTime value)
        : this((OneOf<ParamTime, ParamTimeNullable>)value) { }

    public ParamAsTimeNullable(ParamTimeNullable value)
        : this((OneOf<ParamTime, ParamTimeNullable>)value) { }

    private ParamAsTimeNullable(OneOf<ParamTime, ParamTimeNullable> input)
        : base(input) { }
}
