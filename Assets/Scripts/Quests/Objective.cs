using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Objective
{
    public string description;
    public State state = State.Unassigned;
    public ObjGoal goal;
    public UnityEvent completedObjective;



    public void Complete()
    {
        if (state == State.Assigned)
        {
            if (goal.IsReached())
            {
                state = State.Complete;
                Debug.Log("Objective complete");
                completedObjective.Invoke();
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
