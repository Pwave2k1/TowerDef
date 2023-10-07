using UnityEngine;
using UnityEngine.InputSystem;

public class MousePosition : MonoBehaviour
{
    public Camera cameraMain;
    public LayerMask layerMask;
    Vector3 mousePos;


    private void Update()
    {
        transform.position = GetMousePos();
    }

    private Vector3 GetMousePos()
    {
        Ray ray = cameraMain.ScreenPointToRay(Mouse.current.position.ReadValue());
        if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, layerMask))
        {
            mousePos = hit.point;
        }
        return mousePos;
    }
}