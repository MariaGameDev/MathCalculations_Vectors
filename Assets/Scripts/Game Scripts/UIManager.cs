using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public GameObject tank;
    public GameObject fuel;

    public Text tankPosition;
    public Text fuelPosition;
    public Text energyAmount;
    public Text angle;

    public void AddEnergy(string amount)
    {
        int num;
        if (int.TryParse(amount, out num))
        {
            energyAmount.text = amount;
        }
        
    }

    public void SetAngle(string amount)
    {
        float number;
        if (float.TryParse(amount, out number))
        {
            // number *= Mathf.PI / 180.0f;
            number *= Mathf.Rad2Deg;
            tank.transform.up = MathCalculations.Rotate(new Coords(tank.transform.up), number, false).ToVector();
        }
    }

    void Start()
    {
        
        fuelPosition.text = fuel.GetComponent<ObjectManager>().objPosition + "";
    }

    
    void Update()
    {
        tankPosition.text = tank.transform.position + "";
    }
}
