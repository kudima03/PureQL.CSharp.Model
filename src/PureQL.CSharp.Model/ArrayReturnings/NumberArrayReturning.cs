using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.EachArithmetics;
using PureQL.CSharp.Model.EachDateArithmetics;
using PureQL.CSharp.Model.EachDateTimeArithmetics;
using PureQL.CSharp.Model.EachTimeArithmetics;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class NumberArrayReturning
    : OneOfBase<
        NumberArrayParameter,
        NumberField,
        NumberArrayScalar,
        EachArithmetic,
        EachDateDiffDays,
        EachDateTimeDiffSeconds,
        EachTimeDiffSeconds
    >
{
    public NumberArrayReturning(NumberArrayParameter parameter)
        : this(
            (OneOf<
                NumberArrayParameter,
                NumberField,
                NumberArrayScalar,
                EachArithmetic,
                EachDateDiffDays,
                EachDateTimeDiffSeconds,
                EachTimeDiffSeconds
            >)
                parameter
        )
    { }

    public NumberArrayReturning(NumberField field)
        : this(
            (OneOf<
                NumberArrayParameter,
                NumberField,
                NumberArrayScalar,
                EachArithmetic,
                EachDateDiffDays,
                EachDateTimeDiffSeconds,
                EachTimeDiffSeconds
            >)
                field
        )
    { }

    public NumberArrayReturning(NumberArrayScalar scalar)
        : this(
            (OneOf<
                NumberArrayParameter,
                NumberField,
                NumberArrayScalar,
                EachArithmetic,
                EachDateDiffDays,
                EachDateTimeDiffSeconds,
                EachTimeDiffSeconds
            >)
                scalar
        )
    { }

    public NumberArrayReturning(EachArithmetic arithmetic)
        : this(
            (OneOf<
                NumberArrayParameter,
                NumberField,
                NumberArrayScalar,
                EachArithmetic,
                EachDateDiffDays,
                EachDateTimeDiffSeconds,
                EachTimeDiffSeconds
            >)
                arithmetic
        )
    { }

    public NumberArrayReturning(EachDateDiffDays diff)
        : this(
            (OneOf<
                NumberArrayParameter,
                NumberField,
                NumberArrayScalar,
                EachArithmetic,
                EachDateDiffDays,
                EachDateTimeDiffSeconds,
                EachTimeDiffSeconds
            >)
                diff
        )
    { }

    public NumberArrayReturning(EachDateTimeDiffSeconds diff)
        : this(
            (OneOf<
                NumberArrayParameter,
                NumberField,
                NumberArrayScalar,
                EachArithmetic,
                EachDateDiffDays,
                EachDateTimeDiffSeconds,
                EachTimeDiffSeconds
            >)
                diff
        )
    { }

    public NumberArrayReturning(EachTimeDiffSeconds diff)
        : this(
            (OneOf<
                NumberArrayParameter,
                NumberField,
                NumberArrayScalar,
                EachArithmetic,
                EachDateDiffDays,
                EachDateTimeDiffSeconds,
                EachTimeDiffSeconds
            >)
                diff
        )
    { }

    private NumberArrayReturning(
        OneOf<
            NumberArrayParameter,
            NumberField,
            NumberArrayScalar,
            EachArithmetic,
            EachDateDiffDays,
            EachDateTimeDiffSeconds,
            EachTimeDiffSeconds
        > input
    )
        : base(input) { }
}
