using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform Player;
    Vector3 Offset = new Vector3(0, 1, -1);
    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + Offset;
    }
}
