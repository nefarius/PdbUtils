using Kaitai;

namespace Nefarius.Shared.PdbUtils.Kaitai.PDB;

internal record TypeNode(KaitaiStruct type)
{
    public IList<TypeNode> XRefs = new List<TypeNode>();
}