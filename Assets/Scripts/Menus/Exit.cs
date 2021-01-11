using UnityEngine;
using UnityEngine.UI;

namespace Menus
{
    public class Exit : MonoBehaviour
    {
        [SerializeField] private Button exitButton;

        private void Awake()
        {
            exitButton.onClick.AddListener(ExitGame);//Добавляем событие нажатие кнопки "закрытие игры"
        }
        private void ExitGame()
        {
            Application.Quit();//Закрываем игру
        }
    }
}
