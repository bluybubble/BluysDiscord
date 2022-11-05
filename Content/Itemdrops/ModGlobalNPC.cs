using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InsulinPen.Content.Materials;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using static Terraria.ModLoader.ModContent;

namespace InsulinPen.content.itemdrops
{
    public class ModGlobalNPC : GlobalNPC
    {
        public override void ModifyNPCLoot(NPC npc, NPCLoot npcLoot)
        {
            if (npc.type == NPCID.Zombie)
            {
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Pancreas>(), 25, 1, 1));
            }

        }
    }
}