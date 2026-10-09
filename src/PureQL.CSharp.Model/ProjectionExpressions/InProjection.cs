using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class InProjection
    : OneOfBase<
        InDecimalProjection,
        InStringProjection,
        InBooleanProjection,
        InDateProjection,
        InTimeProjection,
        InDatetimeProjection,
        InUuidProjection
    >
{
    public InProjection(InDecimalProjection value)
        : this(
            (OneOf<
                InDecimalProjection,
                InStringProjection,
                InBooleanProjection,
                InDateProjection,
                InTimeProjection,
                InDatetimeProjection,
                InUuidProjection
            >)
                value
        )
    { }

    public InProjection(InStringProjection value)
        : this(
            (OneOf<
                InDecimalProjection,
                InStringProjection,
                InBooleanProjection,
                InDateProjection,
                InTimeProjection,
                InDatetimeProjection,
                InUuidProjection
            >)
                value
        )
    { }

    public InProjection(InBooleanProjection value)
        : this(
            (OneOf<
                InDecimalProjection,
                InStringProjection,
                InBooleanProjection,
                InDateProjection,
                InTimeProjection,
                InDatetimeProjection,
                InUuidProjection
            >)
                value
        )
    { }

    public InProjection(InDateProjection value)
        : this(
            (OneOf<
                InDecimalProjection,
                InStringProjection,
                InBooleanProjection,
                InDateProjection,
                InTimeProjection,
                InDatetimeProjection,
                InUuidProjection
            >)
                value
        )
    { }

    public InProjection(InTimeProjection value)
        : this(
            (OneOf<
                InDecimalProjection,
                InStringProjection,
                InBooleanProjection,
                InDateProjection,
                InTimeProjection,
                InDatetimeProjection,
                InUuidProjection
            >)
                value
        )
    { }

    public InProjection(InDatetimeProjection value)
        : this(
            (OneOf<
                InDecimalProjection,
                InStringProjection,
                InBooleanProjection,
                InDateProjection,
                InTimeProjection,
                InDatetimeProjection,
                InUuidProjection
            >)
                value
        )
    { }

    public InProjection(InUuidProjection value)
        : this(
            (OneOf<
                InDecimalProjection,
                InStringProjection,
                InBooleanProjection,
                InDateProjection,
                InTimeProjection,
                InDatetimeProjection,
                InUuidProjection
            >)
                value
        )
    { }

    private InProjection(
        OneOf<
            InDecimalProjection,
            InStringProjection,
            InBooleanProjection,
            InDateProjection,
            InTimeProjection,
            InDatetimeProjection,
            InUuidProjection
        > input
    )
        : base(input) { }
}
