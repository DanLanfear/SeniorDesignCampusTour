using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ObjGoal
{
    public GoalType goalType;
    public int requiredAmount = 0;
    public int currentAmount = 0;

    public bool IsReached()
    {
        return false;
    }

}

public enum GoalType
{
    Class,
    Collect,
    Professor,
    Program
}
