//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import java.util.List;
import java.util.ArrayList;


public class RV extends Vehicle
{
	//declare rv attributes/properties
	private int rvLength;
	private int rvSleepingCapacity;
	
	//declare rv list
	protected static List<RV> allRVs = new ArrayList<>();
	
	//constructors
	public RV(String make, String model, int year, String color, double price)
	{
		super(make, model, year, color, price);
	}
	
	public RV(String make, String model, int year, String color, double price, int length, int sleepingCapacity)
	{
		super(make, model, year, color, price);
		rvLength = length;
		rvSleepingCapacity = sleepingCapacity;
	}
	
	
	//mutators-setters
	protected void setRVLength(String type)
	{
		this.rvLength = Main.getValidIntegerInput("Please enter the Length of the " + type, 16, 45);
	}
	
	protected void setRVSleepingCapacity(String type)
	{
		this.rvSleepingCapacity = Main.getValidIntegerInput("Please enter the Sleeping Capacitry of the " + type, 2, 12);
	}
	
	
	//accessors-getters
	public int getRVLength()
	{
		return rvLength;
	}
	
	public int getRVSleepingCapacity()
	{
		return rvSleepingCapacity;
	}
}
