using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ObjectiveGiver : MonoBehaviour
{
    public ObjectiveList objectives;
    public Player player;
    public GameObject window;
    public TMP_Text descText;

    public void Start()
    {
        window.SetActive(true);
        GiveObjective(0);

    }

    public void GiveObjective(int id)
    {
        objectives.Assign(id);
        //ugly for now might work later
        objectives.objectives[id].completedObjective.AddListener(DisplayCompletedObjective);
        //player.objective = obj;
        DisplayObjective(id);
        
    }

    public void DisplayObjective(int id)
    {
        Debug.Log(objectives.GetObjective(id).description);
        descText.text = objectives.GetObjective(id).description;
    }
    public void DisplayCompletedObjective(int id)
    {
        descText.text = string.Format("<s>{0}</s> {1}", descText.text, objectives.GetObjective(id).state.ToString());
    }
}
