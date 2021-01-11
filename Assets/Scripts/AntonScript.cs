using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Debug = UnityEngine.Debug;

public class AntonScript : MonoBehaviour//Lumberjack
{
    [Header("Transforms")]
    [SerializeField] private Transform leftPosition;
    [Space(height:2)]
    [SerializeField] private Transform rightPosition;
    [Space(height:2)]
    [SerializeField] private Transform createPosition;
    
    [Header("Sprites")]
    [SerializeField] private new SpriteRenderer renderer;

    [Header("Animators")] [SerializeField] private Animator animator;
    
    [Header("Buttons")]
    [SerializeField] private Button leftButton;
    [Space(height:2)]
    [SerializeField] private Button rightButton;
    
    private bool _isLeft;
    private bool _isCut;
    private ScoreScript _scoreScript;

    

    private void Awake()
    {
        animator.enabled = false;
        _isCut = true;
        
        _scoreScript = gameObject.GetComponent<ScoreScript>();
        animator = gameObject.GetComponent<Animator>();
        leftButton.onClick.AddListener(OnClickLeftButton);
        rightButton.onClick.AddListener(OnClickRightButton);
    }

    private void OnClickRightButton()//ну тут логично что нажатие на правую кнопку )))
    {
        Debug.Log("Клик по правой кнопке");
        animator.enabled = true;
        _isLeft = false;
        ChangePosition();
    }
    
    private void OnClickLeftButton()//а тут на левую кнопку
    {
        Debug.Log("Клик по левой кнопке");
        animator.enabled = true;
        _isLeft = true;
        ChangePosition();
    }

    private void ChangePosition()//перемещение игрока на укзанную сторону
    {
        
        _isCut = false;
        renderer.flipX = _isLeft;//поворачиваем по оси Х
        if (_isLeft)
            transform.position = leftPosition.position;
        else
            transform.position = rightPosition.position;
        
        
        _scoreScript.SetScore();//добавляем 1 очко
        Debug.Log("Перемещение на другую сторону");
    }

    private void OnTriggerStay2D(Collider2D collider)//Метод выполняется когда "коллайдер" Антона и коллайдер дерева соприкасаются
    {
        if (!_isCut)
        {
            Debug.Log("Соприкосновение с _" + collider);
            CheckLose(collider, collider.gameObject.tag);
            animator.SetTrigger("Cut");
            collider.transform.position = createPosition.position;//удаленное деверо спавним "над" деревом
            //Destroy(collider.gameObject);
            _isCut = true;
        }
    }


    private void CheckLose(Collider2D collider2d, string tag)
    {
        if (!collider2d.gameObject.CompareTag(tag)) return;
        switch (tag)
        {
            case "left" when transform.position == leftPosition.position:
                _scoreScript.ClearScore();
                Debug.LogError("You Lose");
                SceneManager.LoadScene("GameOver");
                break;
            case "right" when transform.position == rightPosition.position:
                _scoreScript.ClearScore();
                Debug.LogError("You Lose");
                SceneManager.LoadScene("GameOver");
                break;
        }
    }
}