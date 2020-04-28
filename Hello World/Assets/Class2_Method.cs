using UnityEngine;
using UnityEngine.UI;
using System;

public class Class2_Method : MonoBehaviour
{
    [Header("數字欄位")]
    public string left;
    public string right;

    [Header("輸出結果")]
    public Text result;

    /// <summary>
    /// 給左邊使用
    /// </summary>
    /// <param name="n">左邊數值</param>
    public void InputLeft(string n)
    {
        left = n;
    }

    /// <summary>
    /// 給右邊使用
    /// </summary>
    /// <param name="n">右邊數值</param>
    public void InputRight(string n)
    {
        right = n;
    }
    
    public void Add()
    {
        try
        {
            int inputLeft = Int32.Parse(left);
            int inputRight = Int32.Parse(right);
            result.text = inputLeft + " + " + inputRight + " = " + (inputLeft + inputRight);
        }
        catch (Exception)
        {
            print("請填入數字");
            throw;
        }
    }

    public void Substract()
    {
        try
        {
            int inputLeft = Int32.Parse(left);
            int inputRight = Int32.Parse(right);
            result.text = inputLeft + " - " + inputRight + " = " + (inputLeft - inputRight);
        }
        catch (Exception)
        {
            print("請填入數字");
            throw;
        }
    }

    public void Multiply()
    {
        try
        {
            int inputLeft = Int32.Parse(left);
            int inputRight = Int32.Parse(right);
            result.text = inputLeft + " × " + inputRight + " = " + (inputLeft * inputRight);
        }
        catch (Exception)
        {
            print("請填入數字");
            throw;
        }
    }

    public void Divide()
    {
        try
        {
            int inputLeft = Int32.Parse(left);
            int inputRight = Int32.Parse(right);
            if (inputLeft % inputRight == 0)
            {
                result.text = inputLeft + " ÷ " + inputRight + " = " + (inputLeft / inputRight);
            }
            else if (inputLeft / inputRight >= 1)
            {
                result.text = inputLeft + " ÷ " + inputRight + " = " + (inputLeft / inputRight) + " " + (inputLeft % inputRight) + "/" + inputRight;
            }
            else
            {
                result.text = inputLeft + " ÷ " + inputRight + " = " + (inputLeft % inputRight) + "/" + inputRight;
            }
            
        }
        catch (Exception)
        {
            print("請填入數字");
            throw;
        }
    }
}
