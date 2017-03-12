using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
        
    public static readonly string GameVersion = "0.0.1";

    public static GameController Instance { get; set; }

    public Message message;

    public Dictionary<string, object> states;

    void Start() 
    {
        EnableDontDestroyOnLoad();

        message = new Message();
        states = new Dictionary<string, object>();

        message.on("test01", test01 => {
            Debug.Log(test01[0]);
        });
        message.on("test02", test02 => {
            Debug.Log(test02[0]);
        });

       
        SetState("test01", "haha");
        SetState("test02", "hehe");
    }

    public object GetState(string key)
    {
        if(states.ContainsKey(key))
        {
            return states[key];
        } else {
            states[key] = null;
            return null;
        }
    }

    public bool SetState(string key, params object[] value) {
        states[key] = value;
        Debug.Log("action: " + key); 
        message.emit(key, value);
        return true;
    }

    private void EnableDontDestroyOnLoad()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
            Destroy(this);
        }

        DontDestroyOnLoad(this);
    }
}
