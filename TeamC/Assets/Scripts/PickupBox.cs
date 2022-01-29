using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupBox : MonoBehaviour
{
    [SerializeField]
    private GameManager.World Currentworld;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("BINGUS");
            //GameObject.Find("GameManager").GetComponent<GameManager>().swapPlayerWorld(Currentworld);
            GameObject.FindGameObjectWithTag("Player").transform.position = new Vector3(100, 100, 100);
        }
    }
}
