//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import javax.swing.JOptionPane;
import java.util.List;
import java.util.ArrayList;


public class Motorcycle extends Vehicle
{
	//declare motorcycle attributes/properties
	private int motorcycleCC;
	private boolean motorcycleHasSideCar;
	
	//declare motorcycle list
	protected static List<Motorcycle> allMotorcycles = new ArrayList<>();
	
	//constructors
	public Motorcycle(String make, String model, int year, String color, double price)
	{
		super(make, model, year, color, price);
	}
		
	public Motorcycle(String make, String model, int year, String color, double price, int cc, boolean hasSideCar)
	{
		super(make, model, year, color, price);
		motorcycleCC = cc;
		motorcycleHasSideCar = hasSideCar;
	}
	
	
	//mutators-setters
	protected void setMotorcycleCC(String type)
	{
		this.motorcycleCC = Main.getValidIntegerInput("Please enter the Engine Size(cc) of the " + type, 50, 2500);
	}
	
	protected void setMotorcycleHasSideCar(String type)
	{
		int result = JOptionPane.showConfirmDialog(null, "Does the " + type + " have a Side Car?", "Side Car", 			JOptionPane.YES_NO_OPTION);
		this.motorcycleHasSideCar = (result == JOptionPane.YES_OPTION);
	}
	
	
	//accessors-getters
	public int getMotorcycleCC()
	{
		return motorcycleCC;
	}
	
	public boolean getMotorcycleHasSideCar()
	{
		return motorcycleHasSideCar;
	}
}
