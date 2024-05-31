namespace FFXIVClientStructs.FFXIV.Client.LayoutEngine;

/// <summary>
/// Layer is a flat list of instances that are always loaded together.
/// </summary>
[GenerateInterop]
[Inherits<IManagerBase>]
[StructLayout(LayoutKind.Explicit, Size = 0x38)]
public unsafe partial struct LayoutLayer {
    [FieldOffset(0x18)] public ushort LayerGroupId;
    [FieldOffset(0x1A)] public ushort FestivalId;
    [FieldOffset(0x1C)] public ushort FestivalSubId;
    [FieldOffset(0x1E)] public byte Flags;
    //[FieldOffset(0x1F)] public byte u1F;
    //[FieldOffset(0x20)] public ushort u20;
    [FieldOffset(0x28)] public StdMap<uint, Pointer<ILayoutInstance>> Instances;
}
