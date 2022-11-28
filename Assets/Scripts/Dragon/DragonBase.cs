using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Dragon_", menuName = "Dragon/Create New Dragon")]
public class DragonBase : ScriptableObject
{
    [SerializeField] private GameObject dragon;
    [SerializeField] private int maxHP;
    [SerializeField] private int damage;
    [SerializeField] private float delayShot = 1f;
    [SerializeField] private int level;
    

    public GameObject Dragon => dragon;
    public int MaxHp => maxHP;
    public int Damage => damage;
    public float DelayShot => delayShot;
    public int Level => level;
}
