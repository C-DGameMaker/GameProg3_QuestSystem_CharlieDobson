using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Project1FirstPlayable_ZanderG
{
    internal class Hud
    {
        public void PrintHUD(string hudText, Player player, List<Enemy> enemy, Map map, QuestClass quest)
        {
            //+3 is so there's spacing
            Console.SetCursorPosition(0, map.mapLength + 2);
            Console.Write("HUD:");
            Console.Write($"\n{hudText}          ");
            Console.WriteLine($"\nPlayer Health: {player._health.health}. Player Damage: {player._damage}          ");
            Console.WriteLine($"\nEnemy{player._lastEncounteredEnemy + 1}'s Health: {enemy[player._lastEncounteredEnemy]._health.health}. Enemy{player._lastEncounteredEnemy + 1}'s Damage: {enemy[player._lastEncounteredEnemy]._damage}          ");
            Console.Write($"\nQuest 1:{quest.questList[0]} - {quest.DisplayQuestStatus(0)}\nQuest 2:{quest.questList[1]} - {quest.DisplayQuestStatus(1)} \nQuest 3:{quest.questList[2]} - {quest.DisplayQuestStatus(2)} "); // All quests displays - Charlie Dobson
        }

        // Had to comment this out as I couldn't find a way to make it show up alongside the Quests - Charlie Dobson
        public void ChangeEventLog(string eventLogText, Map map)
        {
            //+14 puts Event Log at bottom
            //Console.SetCursorPosition(0, map.mapLength + 12);
            //Console.Write($"Last Event: {eventLogText}                                                                                            ");
        }
    }
}
