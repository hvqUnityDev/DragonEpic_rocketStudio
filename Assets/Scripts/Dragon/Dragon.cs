using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    [SerializeField] private DragonBase _dragonBase;
    
    [SerializeField] private List<Transform> pointsToShot;
    [SerializeField] private GameObject bullet;
    
    [SerializeField] private int level = 0;
    [SerializeField] private int hp;
    
    private float oldTime;
    public bool callToUpdate = false;
    private void Start()
    {
        hp = _dragonBase.MaxHp;
        oldTime = Time.time;
    }

    private void FixedUpdate()
    {
        //Shoot();
    }

    private void Shoot()
    {
        if (Time.time > oldTime + _dragonBase.DelayShot)
        {
            oldTime = Time.time;
            foreach (var point in pointsToShot)
            {
                Instantiate(bullet, point.position, Quaternion.identity);
            }
        }
    }

    private void OnMouseDrag()
    {
        transform.position = Input.mousePosition;
    }

    // tao được move đến thành đó -> tạo ra dragon mới tại vị trí của thằng ki
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.layer == gameObject.layer && !col.GetComponent<Dragon>().callToUpdate)
        {
            callToUpdate = true;
            GameController.i.UpdateDragon(gameObject, col.gameObject);
            Dead(col.gameObject);
        }
    }

    private void Dead(GameObject obj1)
    {
        Destroy(obj1);
        Destroy(gameObject);
    }
    
    public DragonBase DragonBase => _dragonBase;
    public int HP => hp;
}
