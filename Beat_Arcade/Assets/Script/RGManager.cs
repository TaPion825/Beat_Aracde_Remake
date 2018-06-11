﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RGManager : MonoBehaviour
{
    private static List<GameObject>[] note_list;
    public GameObject note;
    float time;
    // Use this for initialization
    void Awake()
    {
        note_list = new List<GameObject>[3];
        note_list[0] = new List<GameObject>();
        note_list[1] = new List<GameObject>();
        note_list[2] = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if(time > 3)
        {
            time = 0;

        }
    }

    public static void Add_Note(GameObject note, int num)
    {
        note_list[num].Add(note);
    }

    public static void Remove_Note(GameObject note, int num)
    {
        note_list[num].Remove(note);
    }

    public static void Btn_Hit(int num)
    {
        note_list[num][0].SendMessage("Judge");
    }

    void Make_Note(int num)
    {
        
    }
}