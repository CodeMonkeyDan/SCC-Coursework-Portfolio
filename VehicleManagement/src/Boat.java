//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import java.util.List;
import java.util.ArrayList;


public class Boat extends Vehicle
{
	//declare boat attributes/properties
	private int boatLength;
	private int boatHP;
	
	//declare boat list
	protected static List<Boat> allBoats = new ArrayList<>();
	
	
	//constructors
	public Boat(String make, String model, int year, String color, double price)
	{
		super(make, model, year, color, price);
	}
	
	public Boat(String make, String model, int year, String color, double price, int length, int hp)
	{
		super(make, model, year, color, price);
		boatLength = length;
		boatHP = hp;
	}
	
	
	//mutators-setters
	protected void setBoatLength(String type)
	{
		this.boatLength = Main.getValidIntegerInput("Please enter the Length of the " + type, 8, 100);
	}
	
	protected void setBoatHP(String type)
	{
		this.boatHP = Main.getValidIntegerInput("Please enter the Horse Power of the " + type, 5, 5000);
	}
	
	
	//accessors-getters
	public int getBoatLength()
	{
		return boatLength;
	}
	
	public int getBoatHP()
	{
		return boatHP;
	}
}
