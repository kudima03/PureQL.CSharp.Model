using OneOf;
using PureQL.CSharp.Model.Aggregates;
using PureQL.CSharp.Model.Aggregates.Numeric;
using PureQL.CSharp.Model.Arithmetics;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class NumberReturning
    : OneOfBase<NumberParameter, NumberScalar, Arithmetic, NumberAggregate, Count>
{
    public NumberReturning(NumberParameter parameter)
        : this(
            (OneOf<NumberParameter, NumberScalar, Arithmetic, NumberAggregate, Count>)
                parameter
        )
    { }

    public NumberReturning(NumberScalar scalar)
        : this(
            (OneOf<NumberParameter, NumberScalar, Arithmetic, NumberAggregate, Count>)
                scalar
        )
    { }

    public NumberReturning(Arithmetic arithmetic)
        : this(
            (OneOf<NumberParameter, NumberScalar, Arithmetic, NumberAggregate, Count>)
                arithmetic
        )
    { }

    public NumberReturning(NumberAggregate aggregate)
        : this(
            (OneOf<NumberParameter, NumberScalar, Arithmetic, NumberAggregate, Count>)
                aggregate
        )
    { }

    public NumberReturning(Count count)
        : this(
            (OneOf<NumberParameter, NumberScalar, Arithmetic, NumberAggregate, Count>)
                count
        )
    { }

    private NumberReturning(
        OneOf<NumberParameter, NumberScalar, Arithmetic, NumberAggregate, Count> input
    )
        : base(input) { }
}
