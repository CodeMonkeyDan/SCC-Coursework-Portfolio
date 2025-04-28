//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import java.util.List;
import java.util.ArrayList;


public class Truck extends Vehicle
{
	//declare truck attributes/properties
	private int truckBedLength;
	private int truckTowingCapacity;
	
	//declare truck list
	protected static List<Truck> allTrucks = new ArrayList<>();
	
	
	//constructors
	public Truck(String make, String model, int year, String color, double price)
	{
		super(make, model, year, color, price);
	}
	
	public Truck(String make, String model, int year, String color, double price, int bedLength, int towingCapacity)
	{
		super(make, model, year, color, price);
		truckBedLength = bedLength;
		truckTowingCapacity = towingCapacity;
	}
	
	
	//mutators-setters
	protected void setTruckBedLength(String type)
	{
		this.truckBedLength = Main.getValidIntegerInput("Please enter the Length of the bed on the " + type, 6, 8);
	}
	
	protected void setTruckTowingCapacity(String type)
	{
		this.truckTowingCapacity = Main.getValidIntegerInput("Please enter the Towing Capacity of the " + type, 2000, 			50000);
	}
	
	
	//accessors-getters
	public int getTruckBedLength()
	{
		return truckBedLength;
	}
	
	public int getTruckTowingCapacity()
	{
		return truckTowingCapacity;
	}
}