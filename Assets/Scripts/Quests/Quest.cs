using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Quest
{
    public string description;
    public int id;
    public State state = State.Unassigned;
    public QuestGoal goal;
    public QuestCompletionEvent completedObjective;




    public void Complete()
    {
        if (state == State.Assigned)
        {
            if (goal.IsReached())
            {
                state = State.Complete;
                Debug.Log("Objective complete");
                completedObjective.Invoke(id);
            }
        }
    }
}

public enum State
{
    Unassigned,
    Assigned,
    Complete
}