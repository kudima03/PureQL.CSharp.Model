using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class LessThanOrEqualProjection
    : OneOfBase<
        LessThanOrEqualDecimalProjection,
        LessThanOrEqualStringProjection,
        LessThanOrEqualDateProjection,
        LessThanOrEqualTimeProjection,
        LessThanOrEqualDatetimeProjection
    >
{
    public LessThanOrEqualProjection(LessThanOrEqualDecimalProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualStringProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualDateProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualTimeProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualDatetimeProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    private LessThanOrEqualProjection(
        OneOf<
            LessThanOrEqualDecimalProjection,
            LessThanOrEqualStringProjection,
            LessThanOrEqualDateProjection,
            LessThanOrEqualTimeProjection,
            LessThanOrEqualDatetimeProjection
        > input
    )
        : base(input) { }
}
