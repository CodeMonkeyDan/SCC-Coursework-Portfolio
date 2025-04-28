//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import javax.swing.JOptionPane;
import java.util.List;
import java.util.ArrayList;


public class Car extends Vehicle
{
	//declare car attributes/properties
	private int carNumDoors;
	private boolean carIsConvertible;
	
	//declare car list
	protected static List<Car> allCars = new ArrayList<>();
	
	
	//constructors
	public Car(String make, String model, int year, String color, double price)
	{
		super(make, model, year, color, price);
	}
	
	public Car(String make, String model, int year, String color, double price, int numDoors, boolean isConvertible)
	{
		super(make, model, year, color, price);
		this.carNumDoors = numDoors;
		this.carIsConvertible = isConvertible;
	}
	
	
	//mutators-setters
	protected void setCarNumDoors(String type)
	{
		this.carNumDoors = Main.getValidIntegerInput("Please enter the Number of Doors on the " + type, 2, 8);
	}
	
	protected void setCarIsConvertible(String type)
	{
		int result = JOptionPane.showConfirmDialog(null, "Is the " + type + " a Convertible?", "Car Top", 			JOptionPane.YES_NO_OPTION);
		this.carIsConvertible = (result == JOptionPane.YES_OPTION);
	}
	
	
	//accessors-getters
	public int getCarNumDoors()
	{
		return carNumDoors;
	}
	
	public boolean getCarIsConvertible()
	{
		return carIsConvertible;
	}
}
