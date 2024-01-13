using Infiniscryption.PackManagement;

namespace boneSigils.Managers
{
    public static class CreateCardPack
    {

        public static void CreatePack()
        {
            PackInfo incrediPack = PackManager.GetPackInfo("void");
            incrediPack.Title = "Bone Booster Pack";
            incrediPack.SetTexture(SigilUtils.GetTextureFromPath("bone_pack.png"));
            incrediPack.Description = "A 40+ card expansion that is designed to make playing pure bone decks viable, by increasing the speed of bones and adding a lot of bone support.";
            incrediPack.ValidFor.Add((PackInfo.PackMetacategory)CardTemple.Nature);
        }
    }
}
