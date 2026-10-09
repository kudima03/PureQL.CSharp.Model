using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ComparisonProjection
    : OneOfBase<
        EqualProjection,
        NotEqualProjection,
        InProjection,
        GreaterThanProjection,
        LessThanProjection,
        GreaterThanOrEqualProjection,
        LessThanOrEqualProjection
    >
{
    public ComparisonProjection(EqualProjection value)
        : this(
            (OneOf<
                EqualProjection,
                NotEqualProjection,
                InProjection,
                GreaterThanProjection,
                LessThanProjection,
                GreaterThanOrEqualProjection,
                LessThanOrEqualProjection
            >)
                value
        )
    { }

    public ComparisonProjection(NotEqualProjection value)
        : this(
            (OneOf<
                EqualProjection,
                NotEqualProjection,
                InProjection,
                GreaterThanProjection,
                LessThanProjection,
                GreaterThanOrEqualProjection,
                LessThanOrEqualProjection
            >)
                value
        )
    { }

    public ComparisonProjection(InProjection value)
        : this(
            (OneOf<
                EqualProjection,
                NotEqualProjection,
                InProjection,
                GreaterThanProjection,
                LessThanProjection,
                GreaterThanOrEqualProjection,
                LessThanOrEqualProjection
            >)
                value
        )
    { }

    public ComparisonProjection(GreaterThanProjection value)
        : this(
            (OneOf<
                EqualProjection,
                NotEqualProjection,
                InProjection,
                GreaterThanProjection,
                LessThanProjection,
                GreaterThanOrEqualProjection,
                LessThanOrEqualProjection
            >)
                value
        )
    { }

    public ComparisonProjection(LessThanProjection value)
        : this(
            (OneOf<
                EqualProjection,
                NotEqualProjection,
                InProjection,
                GreaterThanProjection,
                LessThanProjection,
                GreaterThanOrEqualProjection,
                LessThanOrEqualProjection
            >)
                value
        )
    { }

    public ComparisonProjection(GreaterThanOrEqualProjection value)
        : this(
            (OneOf<
                EqualProjection,
                NotEqualProjection,
                InProjection,
                GreaterThanProjection,
                LessThanProjection,
                GreaterThanOrEqualProjection,
                LessThanOrEqualProjection
            >)
                value
        )
    { }

    public ComparisonProjection(LessThanOrEqualProjection value)
        : this(
            (OneOf<
                EqualProjection,
                NotEqualProjection,
                InProjection,
                GreaterThanProjection,
                LessThanProjection,
                GreaterThanOrEqualProjection,
                LessThanOrEqualProjection
            >)
                value
        )
    { }

    private ComparisonProjection(
        OneOf<
            EqualProjection,
            NotEqualProjection,
            InProjection,
            GreaterThanProjection,
            LessThanProjection,
            GreaterThanOrEqualProjection,
            LessThanOrEqualProjection
        > input
    )
        : base(input) { }
}
