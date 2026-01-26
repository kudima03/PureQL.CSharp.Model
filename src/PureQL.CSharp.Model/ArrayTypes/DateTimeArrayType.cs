using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ArrayTypes;

public sealed record DateTimeArrayType : IType
{
    public string Name => "datetimeArray";
}
