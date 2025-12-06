using HarmonyLib;
using SaturnTemp.Notifications;
using Photon.Pun;
using Photon.Realtime;
using System.IO;
using UnityEngine;
using static SaturnTemp.Menu.Main;

namespace SaturnTemp.Patches
{
    [HarmonyPatch(typeof(MonoBehaviourPunCallbacks), "OnPlayerEnteredRoom")]
    internal class JoinPatch
    {
        private static void Prefix(Player newPlayer)
        {
            if (newPlayer != oldnewplayer)
            {
                NotifiLib.SendNotification("<color=grey>[</color><color=green>JOIN</color><color=grey>] </color><color=white>Name: " + newPlayer.NickName + "</color>");
                oldnewplayer = newPlayer;
            }
        }

        private static Player oldnewplayer;
    }
}