using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public void PlaySound() {
        gameObject.GetComponent<AudioSource>().Play();
    }
}
