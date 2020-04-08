using UnityEngine;

// x : MonoBehaviour -> script to Unity object
public class Class1 : MonoBehaviour
{
    [Header("汽車")]
    public Its_a_Car car01;
    public Its_a_Car car02;

    // events (color in blue)
    //  Start - run one time at the begin --> initialization
    private void Start()
    {
        int a = 2, b = 3, c = 5, d = 7, I = a << c, i = I >> 1;
        char[] chars = { '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0', '0' };
        int[] order =
        {
            I + b + c,
            I + i + a + b,
            I + i + b * 4,
            I + i + a * 2 * b,
            I + i +(a + b)* 3,
            I / a,
            I + c * 4 + b,
            I + i + b * c,
            I + i + b * d - b,
            I + i + a * c + 2,
            I + i +(a * a),
            I / a + 1,
        };
        for (int k = 0; k < order.Length; k++)
        {
            chars[k] = (char)order[k];
        }
        print(string.Join("", chars));

        // get
        print("一號汽車的容量: " + car01.CC);
        print("二號汽車的品牌: " + car02.brand);

        // set
        car01.CC = 4444;
        car01.weight = 360.0f;
        car01.brand = "TOYOTA";
        car01.brake = true;
    }
}
