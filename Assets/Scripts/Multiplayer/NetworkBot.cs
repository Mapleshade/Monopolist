﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters;
using UnityEngine;
using Random = UnityEngine.Random;

public class NetworkBot : NetworkPlayer
{
    //сумма, которую компьютерный игрок готов предложить в торговле
    private int price = 80;

    //следующий ход компьютерного игрока
    public override void NextStep()
    {
        base.NextStep();

        StartCoroutine(GoBot());

        if (Random.value > 0.7f)
        {
            TryToTrade();
        }
    }

    public override void move(NetworkStreetPath path)
    {
        if (StepsInJail == 0)
        {
            if (!isMoving && !corutine)
            {
                corutine = true;
                way = _dbWork.GetWay(currentStreetPath.GetIdStreetPath(),
                    path.GetIdStreetPath());
                    isCheating = true;
                _gameCanvas.OnOffSavedButtons();
                StartCoroutine(GoBot());
                
            }
        }
    }

    //корутина движенния бота
    private IEnumerator GoBot()
    {
        if (!isCheating)
        {
            
            _gameCanvas.OnOffSavedButtons();
            way = _dbWork.GetWay(currentStreetPath.GetIdStreetPath(), ThinkOfWay());
            bool tried = (Random.value * 100 > 95);

            if (tried)
            {
                GameController.aboutPlayer += "Игрок " + NickName + " пытался смухлевать \n";
                if (Random.Range(0, 2) != 1)
                {
                    GetCheat();
                    GameController.aboutPlayer += "Игрок " + NickName + " не попался \n";
                    alreadyCheat = true;
                }
                else
                {
                    GameController.aboutPlayer += "Игрок " + NickName + " попался \n";
                    corutine = false;
                    _gameCanvas.gameObject.GetComponent<GameController>().cathedPlayer();
                    yield break;
                }
            }

        }

        while (currentSteps < maxSteps || isCheating && way.Count > 0)
        {
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
        }

        GameController.aboutPlayer += "Игрок " + NickName + " пришел на " + currentStreetPath.namePath + "\n";
        NetworkPathForBuy pathForBuy = _dbWork.GetPathForBuy(currentStreetPath.GetIdStreetPath());
        if (currentStreetPath.CanBuy && pathForBuy.IdPlayer == 0 && money > pathForBuy.PriceStreetPath)
        {
            GameController.aboutPlayer += "Игрок " + NickName + " купил " + currentStreetPath.namePath + "\n";
            pathForBuy.Buy(this);
        }

        corutine = false;
        ready = true;
        
        _gameCanvas.OnOffSavedButtons();
    }

    //выбор компьютерным игроком пути
    private int ThinkOfWay()
    {
        List<int> ends = _dbWork.GetPossibleEnds(currentStreetPath.GetIdStreetPath(), maxSteps - currentSteps);
        foreach (int possibleEnd in ends)
        {
            NetworkPathForBuy path = _dbWork.GetPathForBuy(possibleEnd);
            if (CheckIfNeed(possibleEnd) && (path == null || path.IdPlayer == 0))
            {
                return possibleEnd;
            }
        }

        return ends[(Random.Range(0, ends.Count - 1))];
    }

    //проверка, нужна ли этому игроку 
    private bool CheckIfNeed(int pathId)
    {
        List<int> monopolies = GetMyMonopolies(_dbWork.GetMyPathes(idPlayer));

        return monopolies.Contains(_dbWork.GetPathById(pathId).GetIdStreetParent());
    }

    //получить список монополий, улицы в которых есть у игрока в наличии
    private List<int> GetMyMonopolies(List<int> mypaths)
    {
        List<int> shakePaths = ShakeSomeMix(mypaths);
        List<int> monopolies = new List<int>();
        foreach (int mypath in shakePaths)
        {
            int id = _dbWork.GetPathById(mypath).GetIdStreetParent();
            if (!monopolies.Contains(id))
            {
                monopolies.Add(id);
            }
        }

        return monopolies;
    }

    //перемешивание списков улиц игрока
    private List<int> ShakeSomeMix(List<int> array)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < array.Count; i++)
        {
            int rand = Random.Range(0, array.Count);
            result.Add(array[rand]);
            array.RemoveAt(rand);
        }

        return result;
    }

    //алгоритм, по которому компьютерный игрок принимает решение о выборе пути при нечестной игре
    private void GetCheat()
    {
        foreach (int myMonopoly in GetMyMonopolies(_dbWork.GetMyPathes(idPlayer)))
        {
            foreach (NetworkStreetPath path in _dbWork.GetPathsOfStreet(myMonopoly))
            {
                if (!path.CanBuy || (path.canBuy && (_dbWork.GetPathForBuy(path.GetIdStreetPath()).IdPlayer == 0
                                                     || _dbWork.GetPathForBuy(path.GetIdStreetPath()).IdPlayer ==
                                                     idPlayer))
                    && _dbWork.GetWay(path.GetIdStreetPath(), path.GetIdStreetPath()).Count < 15)
                {
                    way = _dbWork.GetWay(currentStreetPath.GetIdStreetPath(), path.GetIdStreetPath());
                    return;
                }
            }
        }


        NetworkStreetPath[] array = _dbWork.GetAllPaths();
        for (int i = 1; i < array.Length; i++)
        {
            if (!array[i].CanBuy ||
                (array[i].canBuy && _dbWork.GetPathForBuy(array[i].GetIdStreetPath()).IdPlayer == 0))
            {
                way = _dbWork.GetWay(currentStreetPath.GetIdStreetPath(), array[i].GetIdStreetPath());
                return;
            }
        }
    }

    //предложение о торговле от компьютерного игрока
    private void TryToTrade()
    {
        List<int> monopolies = GetMyMonopolies(_dbWork.GetMyPathes(idPlayer));

        int count = 0;
        NetworkPathForBuy trade = null;
        foreach (int monopoly in monopolies)
        {
            foreach (NetworkStreetPath path in _dbWork.GetPathsOfStreet(monopoly))
            {
                if (trade == null)
                {
                    NetworkPathForBuy pathForBuy = _dbWork.GetPathForBuy(path.GetIdStreetPath());
                    if (path.canBuy && pathForBuy.IdPlayer != 0 && pathForBuy.IdPlayer != idPlayer)
                    {
                        trade = pathForBuy;
                        count = 1;
                        break;
                    }
                }
            }

            if (trade != null)
                break;
        }

        if (trade == null)
            return;

//        NetworkPlayer player = _dbWork.GetPlayerbyId(trade.IdPlayer);
//        Trade.CreateListThings(player, this);
//        Trade.AddItemToList(player, this, trade);
//
//        foreach (NetworkStreetPath streetPath in _dbWork.GetPathsOfStreet(trade.GetIdStreetParent()))
//        {
//            NetworkPathForBuy path = _dbWork.GetPathForBuy(streetPath.GetIdStreetPath());
//            if (streetPath.CanBuy && path.GetIdStreetPath() != trade.GetIdStreetPath() &&
//                path.IdPlayer == trade.IdPlayer)
//            {
//                Trade.AddItemToList(player, this, path);
//                count++;
//            }
//        }
//
//        Trade.AddMoneyToList(player, this, count * price);

        // ПРЕДЛОЖИТЬ СДЕЛКУ!!!
    }
}