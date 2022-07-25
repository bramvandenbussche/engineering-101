<Query Kind="Program" />

void Main()
{
	
	var foo = new Car("nen bmw");
	foo.Brand = "BMW";
	foo.NumberOfDoors = 4;
	foo.Type = "X4";
	Car.Counter.Dump();
	
	var bar = new Car("een merk");
	bar.Brand = "Mercedes";
	bar.NumberOfDoors = 5;
	Car.Counter.Dump();
	
	var foobar = new Car("volkswagen", "polo");
	Car.Counter.Dump();
	
	var carPark = new CarPark();
	carPark.Add(foo);
	carPark.Add(bar);
	carPark.Add(foobar);
	
	carPark.GetStatus().Dump();
	carPark.GetCars().Dump();
	carPark.TotalNumberOfDoors().Dump();
}

public class Car
{
	public static int Counter;
	
	public Car(string brand) {
		Counter ++;
		NumberOfDoors = 5;
		Brand = brand;
		Type = "Unknown";
	}
	
	public Car(string brand, string type) {
		Counter ++;
		Brand = brand;
		Type = type;
		NumberOfDoors = 0;
	}
	
	public int NumberOfDoors { get; set; }

	/// <summary>Het merk van den otto</summary>
	public string Brand { get; set; }

	public string Type { get; set; }

	public string MakeNoise()
	{
		return $"{Type} goes vroem vroem";
	}
	
	public static string SoundHorn() {
		return "TUUT TUUT";
	}
	
	public void PopHood() {
		Console.WriteLine("popping hood");
	}
	
	public void PopHood(string foo) {
		Console.WriteLine($"{foo} was here");
		PopHood();
	}
}

public class CarPark {
	
	private List<Car> _cars;
	
	public CarPark() {
		_cars = new List<Car>();
	}
	
	public void Add(Car x) {
		_cars.Add(x);
	}
	
	public string GetStatus() {
		return $"There currently are {_cars.Count} cars parked";	
	}
	
	public Car[] GetCars() {
		return _cars.ToArray();
	}
	
	public int TotalNumberOfDoors() {
		int total = 0;
		foreach (var car in _cars)
		{
			total += car.NumberOfDoors;
		}
		return total;
	}
}