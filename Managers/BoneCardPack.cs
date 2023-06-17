using System;
using Infiniscryption.PackManagement;

namespace boneSigils.Managers
{
    public static class BoneCardPack
    {
        public static void CreatePack()
        {
            PackInfo packInfo = PackManager.GetPackInfo("void");
            packInfo.Title = "Bone Booster Pack";
            packInfo.SetTexture(SigilUtils.GetTextureFromPath("Artwork/bone_pack.png"));
            packInfo.Description = "A 40+ card expansion that is designed to make playing pure bone decks viable, by increasing the speed of bones and adding a lot of bone support.";
            packInfo.ValidFor.Add(0);
        }
    }
}
