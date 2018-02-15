using UnityEngine;
using System.Collections;

public class CamerMovement : MonoBehaviour {

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.mousePosition.x < 20)
        {
            Camera.main.transform.Translate(new Vector3(-0.1f, 0, 0));
        }
        if (Input.mousePosition.x > Screen.width - 20)
        {
            Camera.main.transform.Translate(new Vector3(0.1f, 0, 0));
        }
        if (Input.mousePosition.y < 20)
        {
            Camera.main.transform.Translate(new Vector3(0, -0.1f, 0));
        }
        if (Input.mousePosition.y > Screen.height - 20)
        {
            Camera.main.transform.Translate(new Vector3(0, 0.1f, 0));
        }
    }
}
