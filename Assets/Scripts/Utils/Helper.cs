using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking.Types;

public class Helper
{
    public static bool ValidateCheckEmptyString(Object @object, string fieldName, string stringToCheck)
    {
        if (string.IsNullOrEmpty(stringToCheck))
        {
            Debug.Log(fieldName + "is empty and must contain a value in object" + @object.name.ToString());
            return true;
        }
        return false;
    }

    public static bool ValideCheckEnumerableValues(Object @object, string fieldName, IEnumerable enumerableObjectToCheck)
    {
        
        if (enumerableObjectToCheck != null)
        {
            var item = enumerableObjectToCheck.GetEnumerator().Current;
            if (item != null)
            {
                return false;
            }
        }
        Debug.Log(fieldName + "has no values or null values in object" + @object.name.ToString());
        return true;
    }

}
