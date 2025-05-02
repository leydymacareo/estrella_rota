using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] public UI_HolaMundo holaMundoScript;
    [SerializeField] public Transform ObjectToScale;
    [SerializeField] private float ScaleSpeed = 0.1f;
    [SerializeField] private float minScale = -0.005f;

    private string ScaleText = "Escalado a: ";
    private string WarningText = "No se puede hacer mas pequeño.";
    // Start is called before the first frame update
    void Start()
    {
        holaMundoScript.ChangeTextHM("Empty");
    }

    public void ScaleUp()
    {
        ObjectToScale.localScale += Vector3.one * ScaleSpeed;
        holaMundoScript.ChangeTextHM(ScaleText + ObjectToScale.localScale.x.ToString("F2"));

    }
    public void ScaleDown()
    {
        if(ObjectToScale.localScale.x > minScale)
        {
            ObjectToScale.localScale -= Vector3.one *ScaleSpeed;
            holaMundoScript.ChangeTextHM(ScaleText + ObjectToScale.localScale.x.ToString("F2"));
        }
        else{
            holaMundoScript.ChangeTextHM(WarningText);
        }
    }
}
