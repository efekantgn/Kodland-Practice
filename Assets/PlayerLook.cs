using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    [SerializeField] float mouseSense;
    [SerializeField] Transform player, playerArms;

    float xAxisClamp = 0;

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;


        float rotateX = Input.GetAxis("Mouse X") * mouseSense;
        float rotateY = Input.GetAxis("Mouse Y") * mouseSense;

        xAxisClamp -= rotateY;

        Vector3 rotPlayerArms = playerArms.rotation.eulerAngles;
        Vector3 rotPlayer = player.rotation.eulerAngles;

        rotPlayerArms.x -= rotateY;
        rotPlayerArms.z = 0;
        rotPlayer.y += rotateX;

        if (xAxisClamp > 90)
        {
            xAxisClamp = 89;
            rotPlayerArms.x = 89;
        }
        else if (xAxisClamp < -90)
        {
            xAxisClamp = -89;
            rotPlayerArms.x = -89;
        }

        playerArms.rotation = Quaternion.Euler(rotPlayerArms);
        player.rotation = Quaternion.Euler(rotPlayer);
    }
}
