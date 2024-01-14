using System;
using UnityEngine;

[Serializable]
public class Corporation
{
    private string name; // 회사 이름
    private CorporationType type; // 회사 종류
    private int parValue; // 액면가
    public float maxIncreaseRate = 0.01f; // 틱 당 최대 증가/감소률
    public float minIncreaseRate = -0.01f; // 틱 당 최소 증가/감소률
    
    public string Name => name;
    public CorporationType Type => type;
    public int ParValue => parValue;

    public Corporation(string name, CorporationType type, int initialPrice)
    {
        this.name = name;
        this.type = type;
        this.parValue = initialPrice;
    }

    public void Tick()
    {
        float value = parValue * UnityEngine.Random.Range(1 + minIncreaseRate, 1 + maxIncreaseRate);
        parValue = Mathf.RoundToInt(value); // Temporary Implementation
    }
    
    /// <param name="rate"> 퍼센트 / 100 </param>
    public void IncreaseParValueByRate(float rate)
    {
        parValue = Mathf.RoundToInt(parValue * (1 + rate));
    }
}
