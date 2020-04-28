using UnityEngine;

public class Class3_Method : MonoBehaviour
{
    public Person p1;
    public Person p2;

    private void Start()
    {
        p1.Ask();
        p2.Response();

        print("BMI: " + p1.BMI() + "(" + p1.gameObject.name + "), " + p2.BMI() + "(" + p2.gameObject.name + ")");

        p1.Walk(9, sound:"達達");
        p2.Walk(13, "左");
    }
}
