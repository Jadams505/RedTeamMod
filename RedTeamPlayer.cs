using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace RedTeam
{
    public class RedTeamPlayer : ModPlayer
    {
        
        public override void OnEnterWorld(Player player) {
            player.team = 1;
		}
    }
}