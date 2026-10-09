using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupKeys;

public interface IGroupKey
{
    public string? Alias { get; }

    public IType Type { get; }
}
