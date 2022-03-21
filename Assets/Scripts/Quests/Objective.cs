using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Objective
{
    public string description;
    public int id;
    public State state = State.Unassigned;
    public ObjGoal goal;
    public CompletionEvent completedObjective;




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