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

    public void AddEnergy(string amount)
    {
        int num;
        if (int.TryParse(amount, out num))
        {
            energyAmount.text = amount;
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
