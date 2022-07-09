using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GlobalOptions
{
    private GlobalOptions()
    {
        // Prevent outside instantiation
    }

    private static readonly GlobalOptions _instance = new GlobalOptions();

    public static GlobalOptions GetInstance()
    {   
        if(_instance == null) {
            _instance = new GlobalOptions();
            return _instance;
        }
        else {
            return _instance;
        }
    }

    private static bool isNormalDifficulty = true;

    public void setDifficulty(bool isNormal) {
        isNormalDifficulty = isNormal;
    }

    public bool getDifficulty() {
        return isNormalDifficulty;
    }
}
