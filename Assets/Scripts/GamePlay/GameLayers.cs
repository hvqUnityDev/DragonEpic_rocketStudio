using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameLayers : MonoBehaviour
{ 
    [SerializeField] LayerMask dragon_00;
    [SerializeField] LayerMask dragon_01;
    [SerializeField] LayerMask dragon_02;
    [SerializeField] LayerMask dragon_03;
    [SerializeField] LayerMask dragon_04;
    
    public static GameLayers i { get; private set; }

    private void Awake()
    {
        if(i == null || i == this)
            i = this;
    }
    
    public LayerMask Dragon_00 { get => dragon_00; }
    public LayerMask Dragon_01 { get => dragon_01; }
    public LayerMask Dragon_02 { get => dragon_02; }
    public LayerMask Dragon_03 { get => dragon_03; }
    public LayerMask Dragon_04 { get => dragon_04; }
}
