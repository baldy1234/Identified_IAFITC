using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class rotationHandler : MonoBehaviour
{
    #region rotationVars
    [SerializeField]
    Slider sliderX;
    [SerializeField]
    Slider sliderY;
    [SerializeField]
    Slider sliderZ;

    [SerializeField]
    TextMeshProUGUI rotationDisplay;
    [SerializeField]
    TextMeshProUGUI valuesDisplay;


    Vector3 result;

    [SerializeField]
    float rotationX;
    [SerializeField]
    float rotationY;
    [SerializeField]
    float rotationZ;

    float getDegrees(float floot)
    {
        return floot * 360f;
    }

    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rotationDisplay == null) return;
        rotationX = (sliderX != null) ? getDegrees(sliderX.value) : 0f;
        rotationY = (sliderY != null) ? getDegrees(sliderY.value) : 0f;
        rotationZ = (sliderZ != null) ? getDegrees(sliderZ.value) : 0f;

        Quaternion desiredRotation = Quaternion.Euler(rotationX, rotationY, rotationZ);

        rotationDisplay.text = $"Rotation: {desiredRotation.eulerAngles}";
        valuesDisplay.text = $"Values| x:{rotationX}, y:{rotationY}, z:{rotationZ}";


        
    }
}
