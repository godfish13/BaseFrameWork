using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Utils
{
    public static T GetOrAddComponent<T>(GameObject Target) where T : UnityEngine.Component // Target�� T�� �������� �ҷ����� �ƴϸ� ����
    {
        T Component = Target.GetComponent<T>();
        if (Component == null)
            Component = Target.AddComponent<T>();
        return Component;
    }

    public static GameObject FindChild(GameObject parent, string Childname = null, bool recursive = false)   // UI�׸� ���� GameObject�� enum�� �����ϱ� ����
    {                                                                                               // �Ϲ�ȭ ���� GameObject������ ������
        Transform transform =  FindChild<Transform>(parent, Childname, recursive);      // GameObject�� Monobehavior, ... �� ��ӹ��� ���� ���̶� ����
        if (transform == null)                                                 // �����϶�� ������ �׷��Ƿ� �Ϲ�ȭ�ƴѹ��� ����
            return null;

        return transform.gameObject;
    }

    public static T FindChild<T>(GameObject parent, string Childname = null, bool recursive = false) where T : UnityEngine.Object
    {                                                               //recursive : child�׸� �Ʒ��� child���� Ž������ üũ
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
