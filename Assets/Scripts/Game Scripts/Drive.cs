using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Drive : MonoBehaviour
{
    public float speed = 5.0f;
     public float rotationSpeed = 100.0f;
    public GameObject fuel;
    Vector3 direction;
    float stoppingDist = 0.1f;
    public Text energyAmount;
    Vector3 currentLocation;

    private void Start()
    {
        //  currentLocation = this.transform.position;
        direction = fuel.transform.position - this.transform.position;
        Coords dirNormal = MathCalculations.GetNormal(new Coords(direction));
        direction = dirNormal.ToVector();

        // float angle = MathCalculations.Angle(new Coords(0, 1, 0), new Coords(direction)) * 180.0f/Mathf.PI; //degrees
        float angle = MathCalculations.Angle(new Coords(this.transform.up), new Coords(direction));
        bool clockwise = false;
        if (MathCalculations.CrossProduct(new Coords(this.transform.up), dirNormal).z < 0)
        {
            clockwise = true;
        }

        Coords newDirection = MathCalculations.Rotate(new Coords(0, 1, 0), angle, clockwise);
        this.transform.up = new Vector3(newDirection.x, newDirection.y, newDirection.z);

        Debug.Log("Angle to fuel = " + angle);

        //float angle1 = MathCalculations.Angle(new Coords(0, -2, 0), new Coords(-1, 2, 0)) * 180.0f / Mathf.PI;

        //float angle2 = MathCalculations.Angle(new Coords(0, -2, 0), new Coords(1, 2, 0)) * 180.0f / Mathf.PI;
        //Debug.Log("_____" + angle1);
        //Debug.Log("_____" + angle2);
    }

    void Update()
    {
        TankMovement();
    }

    private void TankMovement()
    {
        if (MathCalculations.Distance(new Coords(this.transform.position), new Coords(fuel.transform.position)) > stoppingDist)
        {
            this.transform.position += direction * speed * Time.deltaTime;
        }
    }

    private void Tank_Movement()
    {
        if (float.Parse(energyAmount.text) <= 0)
        {
            return;
        }
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, translation, 0);

        // Rotate around our y-axis
        transform.Rotate(0, 0, -rotation);

        // vect.Distance is the quare root of a2 + b2, aka hypotenuse !!!
        energyAmount.text = (float.Parse(energyAmount.text) - Vector3.Distance(currentLocation, this.transform.position)) + "";

        currentLocation = this.transform.position;

    }


}