using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LODManagerScript : MonoBehaviour
{
    public GameObject lowPolyModel; //Ссылка на низкополигональную модель объекта
    public GameObject mediumPolyModel; //Ссылка на среднеполигональная модель объекта
    public GameObject highPolyModel;//Ссылка на высокополигональная модель объекта

    public Transform player; //Ссылка на игрока-камеру
    [SerializeField] private float mediumDistance; //дистанция, на которой должно идти переключение на  mediumPolyModel (с возможностью ее изменения через редактор)
    [SerializeField] private float lowDistance; //дистанция, на которой должно идти переключение на  lowPolyModel (с возможностью ее изменения через редактор)

    private bool isBehindPlayer = false; //логическая переменная отвечающая за нахождение объекта в поле зрения игрока (за спиной игрока)

    void Start()
    {
        UpdateLOD();
    }

    void Update()
    {
        UpdateLOD();
    }

    void UpdateLOD() //Метод отвечающий за работу LOD, определение дистанции от игрока до объекта, нахождение объекта в поле зрения игрока 
    {
        float distance = Vector3.Distance(player.position, transform.position);
        Vector3 toPlayer = transform.position - player.position;
        isBehindPlayer = Vector3.Dot(player.forward, toPlayer) < 0;

        //Вызов метода с переданным значением модели объекта в зависимости от дистанции и нахождения их в поле зрения игрока
        if (distance < mediumDistance && !isBehindPlayer)
        {
            SetActiveModel(highPolyModel);
        }
        else if (distance < lowDistance && !isBehindPlayer)
        {
            SetActiveModel(mediumPolyModel);
        }
        else
        {
            SetActiveModel(lowPolyModel);
        }

    }

    void SetActiveModel(GameObject activeModel) //Метод отвечающий за вкл-выкл моделей объекта, а также реализующий включение низкополигональной модели при нахождении ее за спиной игрока
    {
        highPolyModel.SetActive(activeModel == highPolyModel);
        mediumPolyModel.SetActive(activeModel == mediumPolyModel);
        lowPolyModel.SetActive(activeModel == lowPolyModel);

        if (isBehindPlayer)
        {
            highPolyModel.SetActive(false);
            mediumPolyModel.SetActive(false);
            lowPolyModel.SetActive(true);

            this.gameObject.isStatic = true;
        }
    }
}
