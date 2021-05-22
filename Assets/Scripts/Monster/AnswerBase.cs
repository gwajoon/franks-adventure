using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Answer", menuName = "Monster/Create new answer")]

public class AnswerBase : ScriptableObject
{
    [SerializeField] new string name;

    public string Name {
        get { return name; }
    }

}
