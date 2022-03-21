using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class QuestGoal
{
    public GoalType goalType;
    public int requiredAmount = 0;
    public int currentAmount = 0;

    public bool IsReached()
    {
        return (currentAmount >= requiredAmount);
    }

    public void Progress()
    {
        Debug.Log("Goal Progress");

        currentAmount++;
    }
}

public enum GoalType
{
    Class,
    Collect,
    Professor,
    Program
}
