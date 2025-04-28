//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import javax.swing.JOptionPane;
import java.util.List;
import java.util.ArrayList;


public class SUV extends Vehicle
{
	//declare suv attributes/properties
	private int suvSeatingCapacity;
	private boolean suvHasThirdRowSeating;
	
	//declare suv list
	protected static List<SUV> allSUVs = new ArrayList<>();
	
	
	//constructors
	public SUV(String make, String model, int year, String color, double price)
	{
		super(make, model, year, color, price);
	}
	
	public SUV(String make, String model, int year, String color, double price, int seatingCapacity, boolean 		hasThirdRowSeating)
	{
		super(make, model, year, color, price);
		suvSeatingCapacity = seatingCapacity;
		suvHasThirdRowSeating = hasThirdRowSeating;
	}
	
	
	//mutators-setters
	protected void setSUVSeatingCapacity(String type)
	{
		this.suvSeatingCapacity = Main.getValidIntegerInput("Please enter the Seating Capacitry of the " + type, 5, 9);
	}
	
	protected void setHasThirdRowSeating(String type)
	{
		int result = JOptionPane.showConfirmDialog(null, "Does the " + type + " have Third Row Seating?", "Third Row", 			JOptionPane.YES_NO_OPTION);
		this.suvHasThirdRowSeating = (result == JOptionPane.YES_OPTION);
	}
	
	
	//accessors-getters
	public int getSUVSeatingCapacity()
	{
		return suvSeatingCapacity;
	}
	
	public boolean getHasThirdRowSeating()
	{
		return suvHasThirdRowSeating;
	}
}
