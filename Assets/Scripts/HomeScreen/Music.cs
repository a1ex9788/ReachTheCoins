using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private void Start()
    {
        if (Messenger.firstTime) {
            DontDestroyOnLoad(this);
            Messenger.firstTime = false;
        } else {
            Destroy(gameObject);
        }
    }
}
