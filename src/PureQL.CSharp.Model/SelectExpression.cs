using OneOf;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model;

public sealed class SelectExpression
    : OneOfBase<
        BooleanReturning,
        NumberReturning,
        StringReturning,
        DateReturning,
        TimeReturning,
        DateTimeReturning,
        UuidReturning
    >
{
    public SelectExpression(BooleanReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SelectExpression(NumberReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SelectExpression(StringReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SelectExpression(DateReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SelectExpression(TimeReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SelectExpression(DateTimeReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    public SelectExpression(UuidReturning returning)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning
        )
    { }

    private SelectExpression(
        OneOf<
            BooleanReturning,
            NumberReturning,
            StringReturning,
            DateReturning,
            TimeReturning,
            DateTimeReturning,
            UuidReturning
        > input
    )
        : base(input) { }
}
