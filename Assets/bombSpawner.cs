using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bombSpawner : MonoBehaviour
{
    [SerializeField] private GameObject bombPref;
    [SerializeField] private GameObject playerPref;
    [SerializeField] private Canvas fieldPref;

    public void spawner()
    {
        //var cell = Instantiate(bombPref);
        var cell = Instantiate(bombPref, new Vector3(playerPref.transform.position.x + 2f, playerPref.transform.position.y, 0), transform.rotation, fieldPref.transform);
        //cell.transform.localScale = new Vector3(5, 5, 0);
        //cell.transform.localPosition = new Vector3(playerPref.transform.position.x+2f, playerPref.transform.position.y, 0); 
    }

}
