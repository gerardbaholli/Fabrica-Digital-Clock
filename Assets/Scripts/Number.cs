using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Number : MonoBehaviour
{

    [SerializeField] int numberPosition;
    [SerializeField] RawImage rawImage;

    ImageManager imageManager;
    int actualNumber = 9;

    private void Awake()
    {
        imageManager = FindObjectOfType<ImageManager>();
    }

    public void UpdateNumber(string numberValue)
    {
        int tempNumberValue = int.Parse(numberValue);

        if (actualNumber != tempNumberValue)
        {
            rawImage.texture = imageManager.GetImage(tempNumberValue);
            actualNumber = tempNumberValue;
        }  
    }

}
