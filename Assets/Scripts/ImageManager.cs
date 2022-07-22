using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageManager : MonoBehaviour
{

    [SerializeField] Texture[] number0Set;
    [SerializeField] Texture[] number1Set;
    [SerializeField] Texture[] number2Set;
    [SerializeField] Texture[] number3Set;
    [SerializeField] Texture[] number4Set;
    [SerializeField] Texture[] number5Set;
    [SerializeField] Texture[] number6Set;
    [SerializeField] Texture[] number7Set;
    [SerializeField] Texture[] number8Set;
    [SerializeField] Texture[] number9Set;

    public Texture GetImage(int numberValue)
    {

        switch (numberValue)
        {
            case 0:
                return number0Set[Random.Range(0, number0Set.Length)];
            case 1:
                return number1Set[Random.Range(0, number1Set.Length)];
            case 2:
                return number2Set[Random.Range(0, number2Set.Length)];
            case 3:
                return number3Set[Random.Range(0, number3Set.Length)];
            case 4:
                return number4Set[Random.Range(0, number4Set.Length)];
            case 5:
                return number5Set[Random.Range(0, number5Set.Length)];
            case 6:
                return number6Set[Random.Range(0, number6Set.Length)];
            case 7:
                return number7Set[Random.Range(0, number7Set.Length)];
            case 8:
                return number8Set[Random.Range(0, number8Set.Length)];
            case 9:
                return number9Set[Random.Range(0, number9Set.Length)];
            default:
                Debug.LogError("Error, integer number value not between 0 and 9.");
                return null;
        }

    }

}
