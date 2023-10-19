using UnityEngine;

public class Toolbar_Controller : MonoBehaviour
{
    public void Glove_Change()
    {
        Master_Tool.Instance.selected_Tool = 1;
    }

    public void Water_Change()
    {
        Master_Tool.Instance.selected_Tool = 3;
    }

    public void Shovel_Change()
    {
        Master_Tool.Instance.selected_Tool = 2;
    }
}
