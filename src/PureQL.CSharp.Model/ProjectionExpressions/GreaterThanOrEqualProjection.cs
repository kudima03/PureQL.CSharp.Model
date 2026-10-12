using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class GreaterThanOrEqualProjection
    : OneOfBase<
        GreaterThanOrEqualDecimalProjection,
        GreaterThanOrEqualStringProjection,
        GreaterThanOrEqualBooleanProjection,
        GreaterThanOrEqualDateProjection,
        GreaterThanOrEqualTimeProjection,
        GreaterThanOrEqualDatetimeProjection,
        GreaterThanOrEqualUuidProjection
    >
{
    public GreaterThanOrEqualProjection(GreaterThanOrEqualDecimalProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualBooleanProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection,
                GreaterThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualStringProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualBooleanProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection,
                GreaterThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualBooleanProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualBooleanProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection,
                GreaterThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualDateProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualBooleanProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection,
                GreaterThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualTimeProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualBooleanProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection,
                GreaterThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualDatetimeProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualBooleanProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection,
                GreaterThanOrEqualUuidProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualUuidProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualBooleanProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection,
                GreaterThanOrEqualUuidProjection
            >)
                value
        )
    { }

    private GreaterThanOrEqualProjection(
        OneOf<
            GreaterThanOrEqualDecimalProjection,
            GreaterThanOrEqualStringProjection,
            GreaterThanOrEqualBooleanProjection,
            GreaterThanOrEqualDateProjection,
            GreaterThanOrEqualTimeProjection,
            GreaterThanOrEqualDatetimeProjection,
            GreaterThanOrEqualUuidProjection
        > input
    )
        : base(input) { }
}
