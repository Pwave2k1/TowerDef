using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class camController : MonoBehaviour
{
    public float cameraSpeed = 0.25f;
    public float minX = -80;
    public float maxX = 80;
    public float minY = -120;
    public float maxY = 0;
    public float minCamZoom = 20;
    public float maxCamZoom = 195;

    void Update()
    {
        Vector2 deltaMouse = Mouse.current.delta.ReadValue();
        if (Mouse.current.rightButton.isPressed)
        {
            Vector3 moveCam = new Vector3(-deltaMouse.x, 0f, -deltaMouse.y) * cameraSpeed;
            // kẹp 2 giá trị 
            float newX = Mathf.Clamp(transform.position.x + moveCam.x, minX, maxX);
            float newZ = Mathf.Clamp(transform.position.z + moveCam.z, minY, maxY);
            // Áp dụng vị trí mới cho camera
            transform.position = new Vector3(newX, transform.position.y, newZ);
        }
        if (Mouse.current.scroll.IsPressed())
        {
            float scrollValue = Mouse.current.scroll.ReadValue().y;

            // Thực hiện hành động khi giữ chuột trung bình
            float newY = Mathf.Clamp(transform.position.y + (-scrollValue), minCamZoom, maxCamZoom);
            float LerpNewY = Mathf.Lerp(transform.position.y, newY, 0.25f);
            transform.position = new Vector3(transform.position.x, LerpNewY, transform.position.z);
        }

    }
}
