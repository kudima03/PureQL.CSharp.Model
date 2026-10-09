using OneOf;

namespace PureQL.CSharp.Model.Parameters;

public sealed class ParamAsDecimal : OneOfBase<ParamDecimal, ParamInteger>
{
    public ParamAsDecimal(ParamDecimal value)
        : this((OneOf<ParamDecimal, ParamInteger>)value) { }

    public ParamAsDecimal(ParamInteger value)
        : this((OneOf<ParamDecimal, ParamInteger>)value) { }

    private ParamAsDecimal(OneOf<ParamDecimal, ParamInteger> input)
        : base(input) { }
}
