using OneOf;

namespace PureQL.CSharp.Model.EachArithmetics;

public sealed class EachArithmetic
    : OneOfBase<EachAdd, EachSubtract, EachMultiply, EachDivide>
{
    public EachArithmetic(EachAdd add)
        : this((OneOf<EachAdd, EachSubtract, EachMultiply, EachDivide>)add) { }

    public EachArithmetic(EachSubtract subtract)
        : this((OneOf<EachAdd, EachSubtract, EachMultiply, EachDivide>)subtract) { }

    public EachArithmetic(EachMultiply multiply)
        : this((OneOf<EachAdd, EachSubtract, EachMultiply, EachDivide>)multiply) { }

    public EachArithmetic(EachDivide divide)
        : this((OneOf<EachAdd, EachSubtract, EachMultiply, EachDivide>)divide) { }

    private EachArithmetic(OneOf<EachAdd, EachSubtract, EachMultiply, EachDivide> input)
        : base(input) { }
}
