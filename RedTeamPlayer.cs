using Terraria;
using Terraria.ModLoader;

namespace RedTeamMod
{
    public class RedTeamPlayer : ModPlayer
    {
        
        public override void OnEnterWorld(Player player) {
            player.team = 1;
		}
    }
}