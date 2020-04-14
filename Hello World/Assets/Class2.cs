using UnityEngine;

public class Class2 : MonoBehaviour
{
    public int key;

    private void Start()
    {

        #region MATH SIGNAL
        float A = 10, B = 4;
        int a = 10, b = 4;
        string C = "10";
        print("A =" + a + ", B=" + b);

        // add(+), subtract(-), multiply(*), divide(/), module(%)
        print("A + B =" + (A + B));
        print("A - B =" + (A - B));
        print("A * B =" + (A * B));
        print("A / B =" + (A / B) + " (float)");
        print("A / B =" + (a / b) + " (int)");
        print("A % B =" + (A % B));

        // add(+) can concentrate if with a string and a value
        print("$ + B =" + (C + B));

        // binary AND(&), OR(|), XOR(^)
        print("A & B =" + (a & b));
        print("A | B =" + (a | b));
        print("A ^ B =" + (a ^ b));
        #endregion

        #region COMPARITIVE SIGNAL
        int D = 1, E = 2;
        print("D =" + D + ", E=" + E);

        // way higher(>), higher(>=), equal(==), lower(<=), way lower(<), unequal(!=)
        print("D > E →" + (D >  E));
        print("D ≥ E →" + (D >= E));
        print("D < E →" + (D <  E));
        print("D ≤ E →" + (D <= E));
        print("D = E →" + (D == E));
        print("D ≠ E →" + (D != E));
        #endregion

        #region LOGICAL SIGNAL
        bool T = true, F = false;

        // OR(||), AND(&&), inverted(!)
        print("T || F →" + (T || F));
        print("T && F →" + (T && F));
        print("!T →" + !T + ", !F →" + !F);
        #endregion

        #region ASSIGNED SIGNAL
        // left = right, right to left
        key = 1;
        print(key);

        // increment(++), decrement(--)
        print("Keys: " + key);
        print("Keys: " + key++);
        print("Keys: " + key);
        print("Keys: " + --key);
        print("Keys: " + key);

        // add(+=), subtract(-=), multiply(*=), divide(/=), module(%=)
        #endregion

    }
}
