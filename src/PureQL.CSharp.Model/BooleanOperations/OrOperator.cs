using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.BooleanOperations;

public sealed record OrOperator
{
    public OrOperator(BooleanArrayReturning conditions)
        : this((OneOf<IEnumerable<BooleanReturning>, BooleanArrayReturning>)conditions)
    { }

    public OrOperator(IEnumerable<BooleanReturning> conditions)
        : this(
            OneOf<IEnumerable<BooleanReturning>, BooleanArrayReturning>.FromT0(conditions)
        )
    { }

    private OrOperator(
        OneOf<IEnumerable<BooleanReturning>, BooleanArrayReturning> conditions
    )
    {
        Conditions = conditions;
    }

    public OneOf<IEnumerable<BooleanReturning>, BooleanArrayReturning> Conditions { get; }
}
