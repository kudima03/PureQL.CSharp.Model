using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DecimalTotal : OneOfBase<ExactDecimalTotal, IntegerTotal>
{
    public DecimalTotal(ExactDecimalTotal value)
        : this((OneOf<ExactDecimalTotal, IntegerTotal>)value) { }

    public DecimalTotal(IntegerTotal value)
        : this((OneOf<ExactDecimalTotal, IntegerTotal>)value) { }

    private DecimalTotal(OneOf<ExactDecimalTotal, IntegerTotal> input)
        : base(input) { }
}
