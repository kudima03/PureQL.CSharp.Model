using OneOf;

namespace PureQL.CSharp.Model.Returnings;

public sealed class SingleValueReturning
    : OneOfBase<
        BooleanReturning,
        DateReturning,
        DateTimeReturning,
        NumberReturning,
        StringReturning,
        TimeReturning,
        UuidReturning
    >
{
    public SingleValueReturning(BooleanReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                DateReturning,
                DateTimeReturning,
                NumberReturning,
                StringReturning,
                TimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SingleValueReturning(DateReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                DateReturning,
                DateTimeReturning,
                NumberReturning,
                StringReturning,
                TimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SingleValueReturning(DateTimeReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                DateReturning,
                DateTimeReturning,
                NumberReturning,
                StringReturning,
                TimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SingleValueReturning(NumberReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                DateReturning,
                DateTimeReturning,
                NumberReturning,
                StringReturning,
                TimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SingleValueReturning(StringReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                DateReturning,
                DateTimeReturning,
                NumberReturning,
                StringReturning,
                TimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SingleValueReturning(TimeReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                DateReturning,
                DateTimeReturning,
                NumberReturning,
                StringReturning,
                TimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SingleValueReturning(UuidReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                DateReturning,
                DateTimeReturning,
                NumberReturning,
                StringReturning,
                TimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    private SingleValueReturning(
        OneOf<
            BooleanReturning,
            DateReturning,
            DateTimeReturning,
            NumberReturning,
            StringReturning,
            TimeReturning,
            UuidReturning
        > input
    )
        : base(input) { }
}
