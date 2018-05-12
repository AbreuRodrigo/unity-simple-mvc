using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(ByteProperty))]
[CustomPropertyDrawer(typeof(BoolProperty))]
[CustomPropertyDrawer(typeof(IntProperty))]
[CustomPropertyDrawer(typeof(FloatProperty))]
[CustomPropertyDrawer(typeof(DoubleProperty))]
[CustomPropertyDrawer(typeof(ShortProperty))]
[CustomPropertyDrawer(typeof(LongProperty))]
[CustomPropertyDrawer(typeof(StringProperty))]
public class ObservablePropertyDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        EditorGUI.BeginProperty(position, label, property);
        
        position = EditorGUI.PrefixLabel(position, GUIUtility.GetControlID(FocusType.Passive), label);

        var indent = EditorGUI.indentLevel;
        EditorGUI.indentLevel = 0;
        
        EditorGUI.PropertyField(position, property.FindPropertyRelative("field"), GUIContent.none);
        EditorGUI.indentLevel = indent;
        EditorGUI.EndProperty();
    }
}