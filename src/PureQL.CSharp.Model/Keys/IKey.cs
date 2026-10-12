using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public interface IKey
{
    public string Key { get; }

    public IType Type { get; }
}
