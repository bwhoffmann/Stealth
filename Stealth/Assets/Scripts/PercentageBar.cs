using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Have UnityEngine.UI under using calls if canvas UI elements are used.
using UnityEngine.UI;

public class PercentageBar : MonoBehaviour
{
    public float currentValue;
    public float maxValue;
    private Image imageComponent;
    public Color barColor = Color.green;
    public Color barCritColor = Color.cyan;
    public float criticalLevel = 0.25f;

    public Image.FillMethod fillMethod = Image.FillMethod.Horizontal;
    // Start is called before the first frame update
    void Start()
    {
        //Checks to be sure there is an image usable for the bar. If so, sets it to be a filled image.
        imageComponent = gameObject.GetComponent<Image>();
        if (imageComponent != null)
        {
        imageComponent.type = Image.Type.Filled;
        imageComponent.fillMethod = fillMethod;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Returns the difference of current HP and max HP as an amount to fill the bar image.
        float percentOfMax = currentValue/maxValue;

        imageComponent.fillAmount = percentOfMax;

        if (percentOfMax > criticalLevel)
        {
            imageComponent.color = barColor;
        }
        else
        {
            imageComponent.color = barCritColor;
        }
    }
}
