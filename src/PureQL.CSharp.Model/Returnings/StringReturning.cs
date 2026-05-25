using OneOf;
using PureQL.CSharp.Model.Aggregates.String;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class StringReturning : OneOfBase<StringParameter, StringScalar, StringAggregate>
{
    public StringReturning(StringParameter parameter)
        : this((OneOf<StringParameter, StringScalar, StringAggregate>)parameter) { }

    public StringReturning(StringScalar scalar)
        : this((OneOf<StringParameter, StringScalar, StringAggregate>)scalar) { }

    public StringReturning(StringAggregate aggregate)
        : this((OneOf<StringParameter, StringScalar, StringAggregate>)aggregate) { }

    private StringReturning(OneOf<StringParameter, StringScalar, StringAggregate> input)
        : base(input) { }
}
