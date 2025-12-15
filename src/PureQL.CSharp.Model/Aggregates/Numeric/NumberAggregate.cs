using OneOf;

namespace PureQL.CSharp.Model.Aggregates.Numeric;

public sealed class NumberAggregate
    : OneOfBase<AverageNumber, MaxNumber, MinNumber, SumNumber>
{
    public NumberAggregate(SumNumber sumNumber)
        : this((OneOf<AverageNumber, MaxNumber, MinNumber, SumNumber>)sumNumber) { }

    public NumberAggregate(MinNumber minNumber)
        : this((OneOf<AverageNumber, MaxNumber, MinNumber, SumNumber>)minNumber) { }

    public NumberAggregate(MaxNumber maxNumber)
        : this((OneOf<AverageNumber, MaxNumber, MinNumber, SumNumber>)maxNumber) { }

    public NumberAggregate(AverageNumber averageNumber)
        : this((OneOf<AverageNumber, MaxNumber, MinNumber, SumNumber>)averageNumber) { }

    private NumberAggregate(OneOf<AverageNumber, MaxNumber, MinNumber, SumNumber> input)
        : base(input) { }
}
