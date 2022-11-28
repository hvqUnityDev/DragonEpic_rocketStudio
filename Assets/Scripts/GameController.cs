using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController i;
    [SerializeField] private List<DragonBase> listDragons;
    [SerializeField] private List<Dragon> currentDragons;
    [SerializeField] private int maxCurrentDragons = 13;
    [SerializeField] private float timeResetEgg = 3;

    private float oldTSpawn;
    private void Start()
    {
        if (i == null || i != this)
        {
            i = this;
        }

        oldTSpawn = Time.time;
    }


    public void SpawnDragon()
    {
        if (listDragons.Count < maxCurrentDragons && Time.time > oldTSpawn + timeResetEgg)
        {
            GameObject obj = Instantiate(listDragons[0].Dragon, Vector3.zero, Quaternion.identity);
            oldTSpawn = Time.time;
            currentDragons.Add(obj.GetComponent<Dragon>());
        } 
    }

    
    public void UpdateDragon(GameObject obj_1, GameObject obj_2)
    {
        Dragon o1 = obj_1.GetComponent<Dragon>();
        Dragon o2 = obj_2.GetComponent<Dragon>();
        Transform pos = obj_1.transform;
        int level = o1.DragonBase.Level;

        currentDragons.Remove(o1);
        currentDragons.Remove(o2);

        GameObject obj = Instantiate(listDragons[level+1].Dragon, pos.position, Quaternion.identity);
        currentDragons.Add(obj.GetComponent<Dragon>());
        
    }
}


