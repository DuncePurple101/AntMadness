using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoNotDestroy : MonoBehaviour
{
    private static DoNotDestroy instance = null;
    public static DoNotDestroy Instance
    {
        get { return instance; }
    }
    void Awake()
    {
        if(instance!=null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;

        }
        DontDestroyOnLoad(this.gameObject);
    }


}
