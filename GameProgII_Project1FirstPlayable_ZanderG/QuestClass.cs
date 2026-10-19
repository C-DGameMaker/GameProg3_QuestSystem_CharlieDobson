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

        public string[] questList = {"Quest", "Quest", "Win the game" };
        private bool[] questStatus = { false, false, false };

        // Completes a certain quest
        public void CompleteQuest(int questIndex)
        {
            questStatus[questIndex] = true;
        }

        public string DisplayQuestStatus(int questIndex)
        {
            string status = "";
            if (questStatus[0] == true)
            {
                status = "Completed";
            }
            else
            {
                status = "Incompleted";
            }

            return status;
        }
        // checks to see how many quests you have completed
        public int CompleteionChecklist()
        {
            int completedQuests = 0;

            for(int i = 0; i < questStatus.Length; i ++)
            {
                if (questStatus[i] == true)
                {
                    completedQuests++;
                }
            }

            return completedQuests;
        }
    }
}
