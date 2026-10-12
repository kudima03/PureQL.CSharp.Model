using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class StringNullableGroup : OneOfBase<StringGroup, ExactStringNullableGroup>
{
    public StringNullableGroup(StringGroup value)
        : this((OneOf<StringGroup, ExactStringNullableGroup>)value) { }

    public StringNullableGroup(ExactStringNullableGroup value)
        : this((OneOf<StringGroup, ExactStringNullableGroup>)value) { }

    private StringNullableGroup(OneOf<StringGroup, ExactStringNullableGroup> input)
        : base(input) { }
}
