using OneOf;

namespace PureQL.CSharp.Model.Aggregates.DateTime;

public sealed class DateTimeAggregate
    : OneOfBase<MaxDateTime, MinDateTime, AverageDateTime>
{
    public DateTimeAggregate(AverageDateTime averageDateTime)
        : this((OneOf<MaxDateTime, MinDateTime, AverageDateTime>)averageDateTime) { }

    public DateTimeAggregate(MinDateTime minDateTime)
        : this((OneOf<MaxDateTime, MinDateTime, AverageDateTime>)minDateTime) { }

    public DateTimeAggregate(MaxDateTime maxDateTime)
        : this((OneOf<MaxDateTime, MinDateTime, AverageDateTime>)maxDateTime) { }

    private DateTimeAggregate(OneOf<MaxDateTime, MinDateTime, AverageDateTime> input)
        : base(input) { }
}
