using UnityEngine;

public class Person : MonoBehaviour
{
    [Header("身高")]
    public float height;
    [Header("體重")]
    public float weight;

    [Header("武器")]
    public string weapon = "";

    // vold(prefix): no returning values
    public void Ask()
    {
        print("嗯? 你找我?");
    }

    public void Response()
    {
        print("是的" + gameObject.name + "在找你喔");
    }

    public float BMI()
    {
        float result = weight / Mathf.Pow((height / 100), 2);
        return result;
    }

    /// <summary>
    /// 走路的方法
    /// </summary>
    /// <param name="kmh"> 走路速度 </param>
    /// <param name="facing"> 走路面向 </param>
    public void Walk(int kmh, string facing = "前", string sound = "嘎啦嘎拉")
    {
        print(gameObject.name + "用時速" + kmh + "公里, " + sound + "地往" + facing + "方邁進");
    }

    /// <summary>
    /// 攻擊動作
    /// </summary>
    public void doAttack()
    {
        if (weapon.Length == 0)
        {
            Attack();
        }
        else
        {
            Attack(weapon);
        }
    }

    /// <summary>
    /// 徒手攻擊
    /// </summary>
    public void Attack()
    {
        print(gameObject.name + "徒手攻擊!");
    }

    /// <summary>
    /// 拿著武器攻擊
    /// </summary>
    /// <param name="weapon"> 武器名稱 </param>
    public void Attack(string weapon)
    {
        print(gameObject.name + "用" + weapon + "攻擊!");
    }

    // Using condition in Unity button: public, and 1 or fewer value.
    /// <summary>
    /// 技能施放
    /// </summary>
    public void Skill()
    {
        print(gameObject.name + "施放技能!");
    }

}
