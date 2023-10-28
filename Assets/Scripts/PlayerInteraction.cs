using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using static UnityEngine.EventSystems.EventTrigger;

public class PlayerInteraction : MonoBehaviour
{
    public Camera mainCam;
    public float interactionDistance = 10f;

    public GameObject interactionUI;
    public TextMeshProUGUI interactionText;


    public static bool FlashlightInHand = false;
    public GameObject Light;
    public bool onLight;
    public AudioSource AudioSource;
    public AudioClip LightFx;


    void Update()
    {
        InteractionRay();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (FlashlightInHand == true)
            {
                AudioSource.PlayOneShot(LightFx);
                if (onLight == false)
                {
                    Light.SetActive(true);
                    onLight = true;
                }
                else
                {
                    Light.SetActive(false);
                    onLight = false;
                }

            }
        }
    }

    void InteractionRay()
    {
        Ray ray = mainCam.ViewportPointToRay(Vector3.one / 2f);
        RaycastHit hit;

        bool hitSomething = false;

        if (Physics.Raycast(ray, out hit, interactionDistance))
        {
            IInteractable interactable = hit.collider.GetComponent<IInteractable>();

            if (interactable != null)
            {
                hitSomething = true;
                interactionText.text = interactable.GetDescription();

                if (Input.GetKeyDown(KeyCode.E))
                {
                    interactable.Interact();
                }
            }
        }

        interactionUI.SetActive(hitSomething);
    }
}
