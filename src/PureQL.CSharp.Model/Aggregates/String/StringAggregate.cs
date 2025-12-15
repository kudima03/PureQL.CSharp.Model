using OneOf;

namespace PureQL.CSharp.Model.Aggregates.String;

public sealed class StringAggregate : OneOfBase<MaxString, MinString>
{
    public StringAggregate(MaxString maxString)
        : this((OneOf<MaxString, MinString>)maxString) { }

    public StringAggregate(MinString minString)
        : this((OneOf<MaxString, MinString>)minString) { }

    private StringAggregate(OneOf<MaxString, MinString> input)
        : base(input) { }
}
