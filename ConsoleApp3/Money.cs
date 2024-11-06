using System;

internal class Money
{
    private uint _rubles;
    private byte _kopeks;

    public Money(uint rubles, uint kopeks)
    {
        _rubles = rubles;
        _rubles += kopeks / 100;
        _kopeks = (byte)(kopeks % 100);
    }

    public void Print()
    {
        Console.WriteLine($"{_rubles}Руб. {_kopeks}Коп.");
    }

    public static bool Srav(Money m1, Money m2)
    {
        if (m1._rubles != m2._rubles)
        {
            return false;
        }
        else if (m1._kopeks != m2._kopeks)
        {
            return false;
        }
        else
        {
            return  true;
        }
    }

    // Унарные операции
    public static Money operator ++(Money m)
    {
        m._kopeks++;
        if (m._kopeks >= 100)
        {
            m._kopeks -= 100;
            m._rubles++;
        }
        return m;
    }

    public static Money operator --(Money m)
    {
        if ((m._kopeks == 0) && (m._rubles != 0))
        {
            m._kopeks = 99;
            m._rubles--;
        }
        else
        {
            if (m._kopeks != 0) m._kopeks--;
        }
        return m;
    }

    //uint
    public static implicit operator uint(Money m)
    {
        return m._rubles;
    }

    //double
    public static explicit operator double(Money m)
    {
        return m._kopeks / 100.0;
    }

    // Бинарная операция вычитания копеек
    public static Money operator -(Money m, int kopeks)
    {
        int totalKopeks = (int)(m._rubles * 100) + (int)(m._kopeks);

        totalKopeks -= kopeks;

        if (totalKopeks < 0)
        {
            m._rubles = 0;
            m._kopeks = 0;
        }
        else
        {
            m._rubles = (uint)(totalKopeks / 100);
            m._kopeks = (byte)(totalKopeks % 100);
        }
        return m;
    }

    public static Money operator -(int kopeks, Money m)
    {
        int totalKopeks = (int)(m._rubles * 100) + (int)(m._kopeks);

        totalKopeks -= kopeks;

        if (totalKopeks < 0)
        {
            m._rubles = 0;
            m._kopeks = 0;
        }
        else
        {
            m._rubles = (uint)(totalKopeks / 100);
            m._kopeks = (byte)(totalKopeks % 100);
        }
        return m;
    }

    public override string ToString()
    {
        return $"{_rubles}Руб. {_kopeks}Коп.";
    }
}
