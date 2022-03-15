using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ObjectiveGiver : MonoBehaviour
{
    public Objective obj;
    public Player player;
    public GameObject window;
    public TMP_Text descText;

    public void GiveObjective()
    {
        obj.state = State.Assigned;
        player.objective = obj;
        DisplayObjective();
    }

    public void DisplayObjective()
    {
        window.SetActive(true);
        descText.text = obj.description;
    }
    public void DisplayCompletedObjective()
    {
        descText.text = string.Format("<s>{0}</s> {1}", descText.text, obj.state.ToString());
    }
}
