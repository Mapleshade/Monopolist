﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class NetworkPlayer : Photon.MonoBehaviour{

	//ID игрока
    protected int idPlayer;

    protected int viewID;

    //имя игрока
    protected string nickName;

    //деньги игрока
    protected int money;

    //количество ходов, выпавших на кубике
    protected int maxSteps;

    //сколько ходов уже сделал игрок
    protected int currentSteps;

    //банкрот ли игрок
    protected bool isBankrupt;

    //положение игрока на карте
    protected Vector3 destination;

    //скорость передвижения
    public float speed = 20f;

    //ссылка на ДБворк
    protected NetworkDBwork _dbWork;

    //движется ли грок
    protected bool isMoving = false;

    //запущена ли корутина
    protected bool corutine = false;

    //улица, на которой находится игрок
    protected NetworkStreetPath currentStreetPath;

    //путь от одной улицы к другой
    protected Queue<int> way;

    //пытается ли считерить игрок
    protected bool isCheating;

    //будет ли игрок пойман при попытке считерить
    protected bool isGonnaBeCathced;

    //игровая канва
    protected NetworkGameCanvas _gameCanvas;

    //
    protected float angle;

    //завершил ли игрок ход (см gamecontroller)
    public bool ready;

    //сколько ходов игрок заключен под стражу
    protected int StepsInJail;

    //пробовал ли уже игрок жульничать на этом ходе
    protected bool alreadyCheat;

    //под управлением компьютера ли игрок?
    public bool isBot;

    //является ли текущий ход ходом игрока
    protected bool CurrentStep;

    
    float periodSvrRpc = 0.02f; //как часто сервер шлёт обновление картинки клиентам.
    float timeSvrRpcLast = 0; //когда последний раз сервер слал обновление картинки
    
    //пустой консруктор для бота
    public NetworkPlayer()
    {
    }

    public int ViewId
    {
        get { return viewID; }
        set { viewID = value; }
    }

    //вернуть значение является ли ботом
    public bool IsBot()
    {
        return isBot;
    }

    //установить значение, идет ли сейчас ход этого игрока
    public void SetCurrentStep(bool value)
    {
        CurrentStep = value;
    }

    //вернуть значение, идет ли ход игрока
    public bool GetCurrentStep()
    {
        return CurrentStep;
    }

    //получить имя игрока
    public string NickName
    {
        get { return nickName; }
    }

    //получить улицу, на которой стоит игрок
    public NetworkStreetPath GetCurrentStreetPath()
    {
        return currentStreetPath;
    }

    //создаем ссылку на канву игры, объявляет ход игрока 
    void Start()
    {
        if(_dbWork.GetNetworkGameCanvas() != null)
        _gameCanvas = _dbWork.GetNetworkGameCanvas();
        if ((_gameCanvas==null && idPlayer == 1 )|| (_gameCanvas!=null && _gameCanvas.GetComponent<NetworkGameController>().CurrentPlayer!= null && _gameCanvas.GetComponent<NetworkGameController>().CurrentPlayer.IdPlayer == idPlayer))
        CurrentStep = true;
    }

    //перемещение игрока и отправка его данных в игровую канву
    void Update()
    {
       if(GetComponentInChildren<Camera>() != null)
            if (!transform.position.Equals(destination))
            {
                transform.position = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
                isMoving = true;
            }
            else
            {
                isMoving = false;
            }

           
         NetworkGameCanvas.currentSteps = currentSteps;
         NetworkGameCanvas.maxSteps = maxSteps;
         NetworkGameCanvas.money = money;
         NetworkGameCanvas.destination = currentStreetPath.NamePath;
        
    }

    //получить ответ с канвы
    public void takeResponse(bool responce)
    {
        isGonnaBeCathced = responce;
        isCheating = false;
    }

    

    //Корутина движения
    private IEnumerator Go()
    {
        if (alreadyCheat)
        {
            _gameCanvas.ShowInfoAboutEvent("Вы уже мухлевали на этом ходе :(");
            corutine = false;
            yield break;
        }

        bool tried = isCheating;
        yield return new WaitUntil(() => isCheating == false);

        if (tried && isGonnaBeCathced)
        {
            if (Random.Range(0, 2) != 1)
            {
                NetworkGameController.aboutPlayer += "Игрок " + NickName + " не попался \n";
                alreadyCheat = true;
                isGonnaBeCathced = false;
            }
            else
            {
                NetworkGameController.aboutPlayer += "Игрок " + NickName + " попался \n";
                corutine = false;
                _gameCanvas.gameObject.GetComponent<NetworkGameController>().cathedPlayer();
                yield break;
            }
        }
        else if (tried)
        {
            corutine = false;
            yield break;
        }


        bool endFirstStep = false;
        int num = way.Count;
        NetworkStreetPath somewhere = null;
        for (int i = 0; i < num; i++)
        {
            if (i != 0)
                somewhere = _dbWork.GetPathById(way.Dequeue());

            if (i == 0 && !endFirstStep)
            {
                somewhere = _dbWork.GetPathById(way.Dequeue());
                if (currentStreetPath.isBridge &&
                    (currentStreetPath.start.Equals(somewhere.start) ||
                     currentStreetPath.start.Equals(somewhere.end)))
                {
                    destination = currentStreetPath.start;
                    angle = MapBuilder.Angle(transform.position, destination);
                    yield return new WaitUntil(() => transform.position == destination);
                }
                else
                {
                    destination = currentStreetPath.end;
                    angle = MapBuilder.Angle(transform.position, destination);
                    yield return new WaitUntil(() => transform.position == destination);
                }

                endFirstStep = true;
                i--;
                continue;
            }

            if (i == num - 1)
            {
                destination = MapBuilder.GetCenter(somewhere.start, somewhere.end);
                angle = MapBuilder.Angle(transform.position, destination);

                currentStreetPath = somewhere;
                yield return new WaitUntil(() => transform.position == destination);
            }
            else
            {
                if (somewhere.isBridge && transform.position.Equals(somewhere.end))
                {
                    destination = somewhere.start;
                    angle = MapBuilder.Angle(transform.position, destination);
                    yield return new WaitUntil(() => transform.position == destination);
                }
                else
                {
                    destination = somewhere.end;
                    angle = MapBuilder.Angle(transform.position, destination);
                    yield return new WaitUntil(() => transform.position == destination);
                }
            }

            currentSteps++;
        }

        corutine = false;
        _gameCanvas.OnOffSavedButtons();
        if (tried && isGonnaBeCathced)
        {
            _gameCanvas.GetComponent<NetworkGameController>().nextStep();
        }
    }

    //запуск корутины движения
    public virtual void move(NetworkStreetPath path)
    {
       
            if (StepsInJail == 0)
            {
                if (!isMoving && !corutine)
                {
                    corutine = true;
                    way = _dbWork.GetWay(currentStreetPath.GetIdStreetPath(),
                        path.GetIdStreetPath());
                    if (currentSteps + way.Count > maxSteps && !isGonnaBeCathced && !alreadyCheat)
                    {
                        NetworkGameController.aboutPlayer += "Игрок " + NickName + " пытается смухлевать" + "\n";
                        _gameCanvas.OpenWarningWindow(this);
                        isCheating = true;
                    }

                    _gameCanvas.OnOffSavedButtons();
                    StartCoroutine(Go());

                }
            }
            else
            {
                _gameCanvas.ShowInfoAboutEvent("Вы заключены под стражу" + "\n" + "Осталось ходов: " + StepsInJail);
                
            }
        
    }


    //конструктор игрока
    public NetworkPlayer(int idPlayer, string nickName, int money, bool isBankrupt, bool isBot, Vector3 destination)
    {
        this.nickName = nickName;
        this.idPlayer = idPlayer;
        this.money = money;
        this.isBankrupt = isBankrupt;
        this.destination = destination;
        this.isBot = isBot;
    }


    //возврат айдишника игрока
    public int IdPlayer
    {
        get { return idPlayer; }
    }

    //возврат количества денег игрока
    public int Money
    {
        get { return money; }
        set { money = value; }
    }

    //возврат количества ходов, выпавших игроку
    public int MaxSteps
    {
        get { return maxSteps; }
    }

    //возврат ходов, уже проделанных игроком
    public int CurrentSteps
    {
        get { return currentSteps; }
    }

    //возврат банкрот ли игрок
    public bool IsBankrupt
    {
        get { return isBankrupt; }
        set { isBankrupt = value; }
    }

    //возврат положения игрока на карте
    public Vector3 Destination
    {
        get { return destination; }
    }

    //Возврат скорости игрока
    public float Speed
    {
        get { return speed; }
    }

    //получить информацию об игроке из бд
    public void GetData(NetworkPlayer player)
    {
        this.currentSteps = player.CurrentSteps;
        this.destination = player.Destination;
        this.idPlayer = player.IdPlayer;
        this.nickName = player.NickName;
        this.isBankrupt = player.IsBankrupt;
        this.maxSteps = player.MaxSteps;
        this.money = player.Money;
        this.speed = player.Speed;
        this.isBot = player.isBot;

        _dbWork = Camera.main.GetComponent<NetworkDBwork>();


        this.currentStreetPath = findMyPath(destination);
    }
    
    //замена бота на игрока, базируясь на данных бота
    public void GetData(NetworkPlayer player, string nickName)
    {
        this.currentSteps = player.CurrentSteps;
        this.destination = player.Destination;
        this.idPlayer = player.IdPlayer;
        this.nickName = nickName;
        this.isBankrupt = player.IsBankrupt;
        this.maxSteps = player.MaxSteps;
        this.money = player.Money;
        this.speed = player.Speed;
        this.isBot = player.isBot;

        _dbWork = Camera.main.GetComponent<NetworkDBwork>();


        this.currentStreetPath = findMyPath(destination);
    }

    //получить улицу, на которой стоит игрок
    protected NetworkStreetPath findMyPath(Vector3 vector3)
    {
        foreach (NetworkStreetPath streetPath in _dbWork.GetAllPaths())
        {
            if (streetPath.GetIdStreetPath() == 0)
                continue;
            Vector3 pos = streetPath.transform.position;
            if ((int) pos.x == (int) vector3.x && (int) pos.z == (int) vector3.z)
                return streetPath;
        }

        return _dbWork.GetPathById(1);
    }

    //получить текущую улицу
    public NetworkStreetPath CurrentStreetPath
    {
        get { return currentStreetPath; }
    }

    //следующий ход, генерация ходов, выпадающих на кубике
    public virtual void NextStep()
    {
            alreadyCheat = false;
            isGonnaBeCathced = false;

            if (StepsInJail > 0)
            {
                StepsInJail--;
                maxSteps = 0;
            }

            currentSteps = 0;
    }

    public void SetMaxStep(int maxStep)
    {
        this.maxSteps = maxStep;
    }
    
    //находится ли игрок под арестом
    public bool isInJail()
    {
        return StepsInJail > 0;
    }

    //передать информацию об игроке
    public Players getEntity()
    {
        return new Players(idPlayer, nickName, money, destination.x, destination.z, isBankrupt, isBot);
    }

    //если игрок попадается на жульничестве, то он не может двигаться с клетки суда несколько ходов
    public void InJail(int steps)
    {
        StepsInJail = steps;
    }
}
