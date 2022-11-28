using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Egg : MonoBehaviour
{
    private void Start()
    {
        if (GetComponent<EventTrigger>() == null) gameObject.AddComponent<EventTrigger>();
        EventTrigger trigger = gameObject.GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        
        trigger.triggers.Clear();
        entry.callback.AddListener((onClick) =>
        {
            GameController.i.SpawnDragon();
        });
        
        trigger.triggers.Add(entry);
    }
}
