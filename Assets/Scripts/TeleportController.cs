using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class TeleportController : MonoBehaviour
{
    public GameObject baseControllerGameObject;
    public GameObject teleportationGameObject;

    public InputActionReference teleportActivationReference;

    public UnityEvent onTeleportActivate;
    public UnityEvent onTeleportCancel;

    public TeleportController TC;

    void Awake()
    {
        if (TC != null)
        {
            GameObject.Destroy(TC);
        }
        else
        {

            TC = this;
        }

        DontDestroyOnLoad(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        TC.teleportActivationReference.action.performed += TeleportModeActivate;
        TC.teleportActivationReference.action.canceled += TeleportModeCancel;
    }

    private void TeleportModeActivate(InputAction.CallbackContext obj) => onTeleportActivate.Invoke();

    private void TeleportModeCancel(InputAction.CallbackContext obj)
    {
        if (TC != null)
        {
            Invoke("DeactivateTeleporter", .1f);
        }
    }
    void DeactivateTeleporter() => onTeleportCancel.Invoke();
}
