using UnityEngine;

// post script(//), summary(///)
// .cs in project = blueprint, .cs in object = object

/// define the object (car)

public class Its_a_Car : MonoBehaviour
{
    // field(type x;) - storage a object
    // public = access & show on Inspector, private = Not public
    // data type: cc(int), weight(float), brand(string), brake(bool)
    // default int = 0, float = 0, string = "", bool = false
    // Attribute( [attribute(val)] ) = field support in Unity
    // Title = [Header("str")], Tips = [Tooltip("str")]
    
    [Header("汽車屬性調整")]
    /// <summary>
    /// 汽車容量 (單位: cc)
    /// </summary>
    [Tooltip("汽車容量"), Range(500, 5000)]
    public int CC = 2000;
    /// <summary>
    /// 汽車重量 (單位: t)
    /// </summary>
    [Tooltip("汽車重量")]
    public float weight = 102.4f;
    /// <summary>
    /// 汽車品牌
    /// </summary>
    [Tooltip("汽車品牌")]
    public string brand = "BMW";
    /// <summary>
    /// 是否煞車
    /// </summary>
    [Tooltip("是否煞車")]
    public bool brake;
}
