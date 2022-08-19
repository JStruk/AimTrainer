using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] Transform cameraHolder;
    [SerializeField] float mouseSensitivity = 1;
    float verticalLookRotation;

    // Start is called before the first frame update
    void Start()
    {
        lockCursor(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Statistics.timer < TargetShooter.desiredTime)
        {
            lockCursor(true);
            transform.Rotate(Vector3.up * Input.GetAxisRaw("Mouse X") * mouseSensitivity);

            verticalLookRotation -= Input.GetAxisRaw("Mouse Y") * mouseSensitivity;
            verticalLookRotation = Mathf.Clamp(verticalLookRotation, -90f, 90f);

            cameraHolder.localEulerAngles = new Vector3(verticalLookRotation, 0, 0);
            return;
        }
        lockCursor(false);
    }

    private void lockCursor(bool shouldLockCursor)
    {
        if(shouldLockCursor)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            return;
        }
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
