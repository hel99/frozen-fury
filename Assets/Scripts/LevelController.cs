using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] string _nextLevelName;
    EnemySeal[] _seals;
    

    void OnEnable()
    {
        _seals = FindObjectsOfType<EnemySeal>();
    }

    // Update is called once per frame
    void Update()
    {
        if (SealsAreAllDead())
            GoToNextLevel();
    }

    private void GoToNextLevel()
    {
        Debug.Log("Go to level " + _nextLevelName);
    }

    private bool SealsAreAllDead()
    {
        foreach(var seal in _seals)
        {
            if (seal.gameObject.activeSelf)
                return false;
        }
        return true;
    }
}
