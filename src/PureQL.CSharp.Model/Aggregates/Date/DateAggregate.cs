using OneOf;

namespace PureQL.CSharp.Model.Aggregates.Date;

public sealed class DateAggregate : OneOfBase<MaxDate, MinDate, AverageDate>
{
    public DateAggregate(AverageDate averageDate)
        : this((OneOf<MaxDate, MinDate, AverageDate>)averageDate) { }

    public DateAggregate(MinDate minDate)
        : this((OneOf<MaxDate, MinDate, AverageDate>)minDate) { }

    public DateAggregate(MaxDate maxDate)
        : this((OneOf<MaxDate, MinDate, AverageDate>)maxDate) { }

    private DateAggregate(OneOf<MaxDate, MinDate, AverageDate> input)
        : base(input) { }
}
