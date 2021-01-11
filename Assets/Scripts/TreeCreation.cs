using UnityEngine;

public class TreeCreation : MonoBehaviour
{
    // [SerializeField] private GameObject treeType1;
    // [SerializeField] private GameObject treeType2;
    // [SerializeField] private GameObject treeType3;
    // [SerializeField] private int treeCount;

    private ScoreScript _scoreScript;
    //private List<GameObject> _list;

    void Start()
    {
        _scoreScript = gameObject.GetComponent<ScoreScript>();
            //InitDefList();
    }
    //
    // private void InitDefList()
    // {
    //     _list = gameObject.GetComponent<List<GameObject>>();
    //     for (var i = 0; i < treeCount/3; i++)
    //     {
    //         _list.Add(treeType1);//?
    //         _list.Add(treeType2);//?
    //         _list.Add(treeType3);//?
    //     }
    // } 
    //
    // private void CreateAsDefault()
    // {
    //     
    // }
    

}
