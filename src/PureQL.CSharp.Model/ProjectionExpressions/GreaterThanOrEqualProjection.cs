using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class GreaterThanOrEqualProjection
    : OneOfBase<
        GreaterThanOrEqualDecimalProjection,
        GreaterThanOrEqualStringProjection,
        GreaterThanOrEqualDateProjection,
        GreaterThanOrEqualTimeProjection,
        GreaterThanOrEqualDatetimeProjection
    >
{
    public GreaterThanOrEqualProjection(GreaterThanOrEqualDecimalProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualStringProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualDateProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualTimeProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    public GreaterThanOrEqualProjection(GreaterThanOrEqualDatetimeProjection value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalProjection,
                GreaterThanOrEqualStringProjection,
                GreaterThanOrEqualDateProjection,
                GreaterThanOrEqualTimeProjection,
                GreaterThanOrEqualDatetimeProjection
            >)
                value
        )
    { }

    private GreaterThanOrEqualProjection(
        OneOf<
            GreaterThanOrEqualDecimalProjection,
            GreaterThanOrEqualStringProjection,
            GreaterThanOrEqualDateProjection,
            GreaterThanOrEqualTimeProjection,
            GreaterThanOrEqualDatetimeProjection
        > input
    )
        : base(input) { }
}
