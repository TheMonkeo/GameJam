using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private GameObject playerLoc;

    [SerializeField]
    private Transform cubeWorldSpawn;

    [SerializeField]
    private Transform roundWorldSpawn;

    public enum World
    {
        SQURARE, ROUND
    }
    public void swapPlayerWorld(World swapFrom)
    {
        switch (swapFrom)
        {
            case World.SQURARE:
                playerLoc.transform.position = new Vector3 ( 100, 100, 100 );
                break;
            case World.ROUND:
                playerLoc.transform.position = new Vector3(100, 100, 100);
                break;

        }
    }
}
