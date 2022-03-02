using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective
{
    public string description;
    public State state = State.Unassigned;
    public ObjGoal goal;


    public void Complete()
    {
        if (state == State.Assigned)
        {
            if (goal.IsReached())
            {
                state = State.Complete;
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
