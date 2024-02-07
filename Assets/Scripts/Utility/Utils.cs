using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Utils
{
    public static T GetOrAddComponent<T>(GameObject Target) where T : UnityEngine.Component // Target이 T를 가졌으면 불러오고 아니면 붙임
    {
        T Component = Target.GetComponent<T>();
        if (Component == null)
            Component = Target.AddComponent<T>();
        return Component;
    }

    public static GameObject FindChild(GameObject parent, string Childname = null, bool recursive = false)   // UI항목 말고 GameObject도 enum과 연동하기 위해
    {                                                                                               // 일반화 없는 GameObject버전도 만들어둠
        Transform transform =  FindChild<Transform>(parent, Childname, recursive);      // GameObject는 Monobehavior, ... 을 상속받지 않은 것이라 따로
        if (transform == null)                                                 // 구현하라고 오류뜸 그러므로 일반화아닌버전 제작
            return null;

        return transform.gameObject;
    }

    public static T FindChild<T>(GameObject parent, string Childname = null, bool recursive = false) where T : UnityEngine.Object
    {                                                               //recursive : child항목 아래의 child까지 탐색여부 체크
        if (parent == null)
            return null;

        if(recursive == false)
        {
            for(int i = 0; i < parent.transform.childCount; i++)
            {
                Transform transform = parent.transform.GetChild(i);
                if(string.IsNullOrEmpty(Childname) || transform.name == Childname)
                {
                    T component = transform.GetComponent<T>();
                    if(component != null)
                        return component;
                }
            }
        }
        else
        {
            foreach (T component in parent.GetComponentsInChildren<T>())
            {
                if (string.IsNullOrEmpty(Childname) || component.name == Childname)
                    return component;
            }
        }

        return null;
    }
}
