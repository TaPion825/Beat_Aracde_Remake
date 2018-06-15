﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T _instance;
	
    public static T instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType(typeof(T)) as T;

                if(_instance == null)
                {
                    Debug.LogError("이 씬에" + typeof(T) + "이거 없는데?");
                }
            }

            return _instance;
        }
    }
}