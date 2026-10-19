using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProgII_Project1FirstPlayable_ZanderG
{
    internal class QuestClass
    {

        // Summary:

        // Charlie Dobson 
        // A class that runs all the quest logic

        #region Variables

        // Array/List of all current quests
        public string[] questList = {"Raise Damage 3 times", "Take 5 hit points of damage", "Win the game" };

        // Array/List of the status of all current quests
        private bool[] questStatus = { false, false, false };
        #endregion

        #region Methods

        // Completes a certain quest
        public void CompleteQuest(int questIndex)
        {
            questStatus[questIndex] = true;
        }

        // Displays the current Status of the quests
        public string DisplayQuestStatus(int questIndex)
        {
            string status = "";
            if (questStatus[questIndex] == true)
            {
                status = "Completed                     ";
            }
            else
            {
                status = "Incompleted                   ";
            }

            return status;
        }

        // Checks the completeion of each quest and updates accordingly
        public void CheckQuestCompletion(Player player)
        {
            if(player._damagedRaised >= 3)
            {
                CompleteQuest(0);
            }
            if(player._totalDamageTaken >= 1)
            {
                CompleteQuest(1);
            }
        }
        #endregion
    }
}
