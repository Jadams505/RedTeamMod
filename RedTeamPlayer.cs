using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RedTeamMod
{
    public class RedTeamPlayer : ModPlayer
    {
        
        public override void OnEnterWorld() {
            Player.team = 1;
		}

        public override void SendClientChanges(ModPlayer clientPlayer)
		{
            if(Player.team == 1 && clientPlayer.Player.team != 1)
            {
                NetMessage.SendData(MessageID.PlayerTeam, -1, -1, null, Main.myPlayer);
            }
		}

        public override void CopyClientState(ModPlayer clientClone)
        {
            clientClone.Player.team = Player.team;
        }


    }
}