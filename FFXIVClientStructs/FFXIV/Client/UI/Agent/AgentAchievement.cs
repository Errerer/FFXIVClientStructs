namespace FFXIVClientStructs.FFXIV.Client.UI.Agent;

[Agent(AgentId.Achievement)]
[GenerateInterop]
[Inherits<AgentInterface>]
[StructLayout(LayoutKind.Explicit, Size = 0xFD10)]
public partial struct AgentAchievement {
    [MemberFunction("E8 ?? ?? ?? ?? EB ?? 48 8B 46 ?? 48 63 4E")]
    public partial void OpenById(uint achievementId);
}