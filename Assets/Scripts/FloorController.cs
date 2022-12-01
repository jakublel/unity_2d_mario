using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorController : MonoBehaviour
{

    public GameObject floorTile1;
    public GameObject floorTile2;

    public GameObject[] tiles;

   // private void Update()
   //   {
   // Debug.Log("UPDATE");
   //
   // }

    private void Start()
    {
      //  Debug.Log("START");
    }

    void FixedUpdate()
    {
        if (!GameManager.instance.inGame) return;
        Debug.Log("FIXED UPDATE");
        //  Debug.Log($"floorTile1: "+ floorTile1);
        //Debug.Log($"floorTile2 " + floorTile2);
     //   floorTile1.transform.position = new Vector3(GameManager.instance.worldScrollingSpeed, 0f, 0f);
       // floorTile2.transform.position = new Vector3(GameManager.instance.worldScrollingSpeed, 0f, 0f);

       // Debug.Log($"position 1: " + floorTile1.transform.position);
       // Debug.Log($"position 2: " + floorTile2.transform.position);

         //if (floorTile2.transform.position.x < 0f)
         //{
          // Debug.Log("change position");
        // floorTile1.transform.position += new Vector3(16f, 0f, 0f);

        /// var tmp = floorTile1;
        //floorTile1 = floorTile2;
        // floorTile2 = tmp;

         // Debug.Log($"position 1 after chane: " + floorTile1.transform.position);
         //Debug.Log($"position 2 after change: " + floorTile2.transform.position);

         //}
        

        // naprawiam problem



        floorTile1.transform.position += new Vector3(-GameManager.instance.worldScrollingSpeed, 0f, 0f);
        floorTile2.transform.position += new Vector3(-GameManager.instance.worldScrollingSpeed, 0f, 0f);

        if (floorTile1.transform.position.x < 0) 
        {
            var newTile = Instantiate(tiles[Random.Range(0, tiles.Length)],floorTile2.transform.position+new Vector3(18f,0f,0f),Quaternion.identity);
            Destroy(floorTile1);

            
            
            floorTile1 = floorTile2;
            floorTile2 = newTile;


        }

        if (floorTile2.transform.position.x < 0)
        {
            floorTile2.transform.position = new Vector3(18 + 18, -1f, 0f);
            //  var tmp = floorTile1;
            //  floorTile1 = floorTile2;
            //  floorTile2 = tmp;


        }


        Debug.Log($"position 1 after change: " + floorTile1.transform.position);
        Debug.Log($"position 2 after change: " + floorTile2.transform.position);

    }
}
