using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawnerMultiplayer : MonoBehaviour
{
    public GameObject coinPrefab;

    Vector2[] positions;

    float count = 0;

    // Start is called before the first frame update
    void Start()
    {
        string aux = "6 1,7 -6 1,7 0 3 -6 -2,3 6 -2,3 6 4 -6 4 3 4 -3 4 0 -0,3 1,5 -0,3 -1,5 -0,3 4 -1 -4 -1 0 -2,5";
        char[] separator = { ' ' };
        string[] splits = aux.Split(separator);

        positions = new Vector2[splits.Length / 2];
        int j = 0;
        for (int i = 0; i < splits.Length; i += 2)
        {
            positions[j++] = new Vector2(float.Parse(splits[i]), float.Parse(splits[i + 1]));
        }
    }

    private void Update()
    {
        count += Time.deltaTime;
        if (count >= 2) {
            count = 0;

            NewCoin();
        }
    }

    public void NewCoin()
    {
        int random = Random.Range(0, positions.Length);
        Instantiate(coinPrefab, new Vector3(positions[random].x, positions[random].y, 0), new Quaternion());
    }
}
