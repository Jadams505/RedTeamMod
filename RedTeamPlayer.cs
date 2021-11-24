using Terraria;
using Terraria.ModLoader;

namespace RedTeamMod
{
    public class RedTeamPlayer : ModPlayer
    {
        
        public override void OnEnterWorld(Player player) {
            player.team = 1;
		}

        public override void SendClientChanges(ModPlayer clientPlayer)
		{
            if(player.team == 1 && clientPlayer.player.team != 1)
            {
                NetMessage.SendData(45, -1, -1, null, Main.myPlayer);
            }
		}

        public override void clientClone(ModPlayer clientClone)
        {
            clientClone.player.team = player.team;
        }


    }
}