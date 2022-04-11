using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CORE : MonoBehaviour
{
    public Transorm enemyPrefab;
    public Transform spawnPoint;



    public static void addRoomGo(GameObject go)
    {
        CORE.theRooms.Add(go);
        print("Added Room");
    }

    public static void display()
    {
        print("Woot");
    }

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Instantiate()
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
