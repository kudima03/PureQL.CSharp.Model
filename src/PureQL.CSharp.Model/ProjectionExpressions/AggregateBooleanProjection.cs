using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateBooleanProjection
    : OneOfBase<MinBooleanProjection, MaxBooleanProjection, AnyProjection, AllProjection>
{
    public AggregateBooleanProjection(MinBooleanProjection value)
        : this(
            (OneOf<
                MinBooleanProjection,
                MaxBooleanProjection,
                AnyProjection,
                AllProjection
            >)
                value
        )
    { }

    public AggregateBooleanProjection(MaxBooleanProjection value)
        : this(
            (OneOf<
                MinBooleanProjection,
                MaxBooleanProjection,
                AnyProjection,
                AllProjection
            >)
                value
        )
    { }

    public AggregateBooleanProjection(AnyProjection value)
        : this(
            (OneOf<
                MinBooleanProjection,
                MaxBooleanProjection,
                AnyProjection,
                AllProjection
            >)
                value
        )
    { }

    public AggregateBooleanProjection(AllProjection value)
        : this(
            (OneOf<
                MinBooleanProjection,
                MaxBooleanProjection,
                AnyProjection,
                AllProjection
            >)
                value
        )
    { }

    private AggregateBooleanProjection(
        OneOf<
            MinBooleanProjection,
            MaxBooleanProjection,
            AnyProjection,
            AllProjection
        > input
    )
        : base(input) { }
}
