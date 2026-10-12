using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateBooleanTotal : OneOfBase<AnyTotal, AllTotal>
{
    public AggregateBooleanTotal(AnyTotal value)
        : this((OneOf<AnyTotal, AllTotal>)value) { }

    public AggregateBooleanTotal(AllTotal value)
        : this((OneOf<AnyTotal, AllTotal>)value) { }

    private AggregateBooleanTotal(OneOf<AnyTotal, AllTotal> input)
        : base(input) { }
}
