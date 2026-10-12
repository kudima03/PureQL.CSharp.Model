using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class LessThanOrEqualProjection
    : OneOfBase<
        LessThanOrEqualDecimalProjection,
        LessThanOrEqualStringProjection,
        LessThanOrEqualBooleanProjection,
        LessThanOrEqualDateProjection,
        LessThanOrEqualTimeProjection,
        LessThanOrEqualDatetimeProjection,
        LessThanOrEqualUuidProjection
    >
{
    public LessThanOrEqualProjection(LessThanOrEqualDecimalProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualBooleanProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection,
                LessThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualStringProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualBooleanProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection,
                LessThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualBooleanProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualBooleanProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection,
                LessThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualDateProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualBooleanProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection,
                LessThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualTimeProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualBooleanProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection,
                LessThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualDatetimeProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualBooleanProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection,
                LessThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public LessThanOrEqualProjection(LessThanOrEqualUuidProjection value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalProjection,
                LessThanOrEqualStringProjection,
                LessThanOrEqualBooleanProjection,
                LessThanOrEqualDateProjection,
                LessThanOrEqualTimeProjection,
                LessThanOrEqualDatetimeProjection,
                LessThanOrEqualUuidProjection
            >)
                value
        )
    { }

    private LessThanOrEqualProjection(
        OneOf<
            LessThanOrEqualDecimalProjection,
            LessThanOrEqualStringProjection,
            LessThanOrEqualBooleanProjection,
            LessThanOrEqualDateProjection,
            LessThanOrEqualTimeProjection,
            LessThanOrEqualDatetimeProjection,
            LessThanOrEqualUuidProjection
        > input
    )
        : base(input) { }
}
