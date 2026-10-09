using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public interface IKey
{
    public int Key { get; }

    public IType Type { get; }
}
