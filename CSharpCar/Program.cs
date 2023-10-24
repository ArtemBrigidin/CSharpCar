using System;

public interface IVehicle
{
    void Move();
    void Refill(int oilCount);
}

public class Car : IVehicle
{
    private int oilCount;

    public Car(int initialOilCount)
    {
        if (initialOilCount < 0)
        {
            throw new ArgumentException("Начальное количество бензина не может быть отрицательным.");
        }
        this.oilCount = initialOilCount;
    }

    public void Move()
    {
        if (oilCount >= 100)
        {
            Console.WriteLine("Автомобиль едет.");
            oilCount -= 100; // Расходуем 100 единиц бензина при каждом вызове Move()
        }
        else
        {
            Console.WriteLine("Не достаточно бензина для передвижения.");
        }
    }

    public void Refill(int oilCountToAdd)
    {
        if (oilCountToAdd < 0)
        {
            throw new ArgumentException("Объём добавляемого бензина не может быть отрицательным.");
        }
        oilCount += oilCountToAdd;
        Console.WriteLine($"Залито {oilCountToAdd} единиц бензина. Текущее количество бензина: {oilCount}");
    }
}

class Program
{
    static void Main()
    {
        Car myCar = new Car(200);

        myCar.Move();
        myCar.Refill(50);
        myCar.Move();
        myCar.Move();
    }
}
