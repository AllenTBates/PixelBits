using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour
{

    private bool isOrtho = false;
    public GameObject player;

    void Update()
    {
        //Camera.main.transform.rotation = Quaternion.Euler(new Vector3(-(Input.mousePosition.y)/50f, Input.mousePosition.x/50f, 0));

        if (isOrtho)
        {
            Camera.main.transform.position = new Vector3(player.transform.position.x - 10.0f, player.transform.position.y, player.transform.position.z + 5.0f);
            Camera.main.transform.rotation = Quaternion.Euler(new Vector3(0, 90f, 0));

            if (Input.GetKeyDown(KeyCode.O))
                isOrtho = false;

        }
        else
        {
            //Press "O" to go into Orthographic View
            if (Input.GetKeyDown(KeyCode.O))
                isOrtho = true;
        }
        //Camera.main.transform.LookAt(player.transform);
    }

}
