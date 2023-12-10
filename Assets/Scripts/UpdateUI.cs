using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpdateUI : MonoBehaviour
{
    private Dictionary<GameObject, string> uiObjects = new Dictionary<GameObject, string>();
    // Start is called before the first frame update
    void Start()
    {

        // Only way to add items to dictionary is to do it manually

        
        uiObjects.Add(GameObject.Find("Scoopula"), "Scoopula");
        uiObjects.Add(GameObject.Find("StirringRod"), "glass stir bar");
        uiObjects.Add(GameObject.Find("Funnel"), "Funnel");
        uiObjects.Add(GameObject.Find("GraduatedCylinder"), "Graduated Cylinder");
        uiObjects.Add(GameObject.Find("Goggles"), "SAFETY GOGGLES");
        uiObjects.Add(GameObject.Find("MagneticStirBar"), "MAGNETIC STIR BAR");
        uiObjects.Add(GameObject.Find("VialBase"), "vial with cap");
        uiObjects.Add(GameObject.Find("WatchGlass"), "Watch Glass");
        uiObjects.Add(GameObject.Find("VolumetricFlaskGlass"), "Volumetric Flask");
        uiObjects.Add(GameObject.Find("TestTube"), "test tube");
        uiObjects.Add(GameObject.Find("Pipette"), "Pipet");
        uiObjects.Add(GameObject.Find("BunsenBurner"), "BUNSEN BURNER");
        uiObjects.Add(GameObject.Find("ErenmyerFlask"), "erlenmeyer flask");
        uiObjects.Add(GameObject.Find("Beaker (1)"), "Beaker");
        uiObjects.Add(GameObject.Find("CrucibleTongs"), "CRUCIBLE TONGS");
        uiObjects.Add(GameObject.Find("Centrifuge"), "CENTRIFUGE");
        uiObjects.Add(GameObject.Find("RingStand"), "Ring Stand");
    }

    public void UpdateImage(GameObject obj)
    {
        GameObject.Find("Image").GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>(uiObjects[obj]);
    }

    public void RemoveImage()
    {
        GameObject.Find("Image").GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<Sprite>("transparent");
    }
}
