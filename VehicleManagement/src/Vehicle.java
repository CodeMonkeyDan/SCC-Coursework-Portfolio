//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import javax.swing.JOptionPane;
import java.util.List;
import java.util.ArrayList;


public class Vehicle
{
	//declare vehicle attributes/properties
	private String vehicleMake;
	private String vehicleModel;
	private int vehicleYear;
	private String vehicleColor;
	private double vehiclePrice;
	
	//declare vehicle list
	protected static List<Vehicle> allVehicles = new ArrayList<>();
	
	
	//constructors
	public Vehicle()
	{
		
	}
	
	public Vehicle(String make, String model, int year, String color, double price)
	{
		this.vehicleMake = make;
		this.vehicleModel = model;
		this.vehicleYear = year;
		this.vehicleColor = color;
		this.vehiclePrice = price;
	}
	
	
	//mutators-setters
	protected void setVehicleMake(String type)
	{
		this.vehicleMake = getValidStringInput("Please enter the Make of the " + type);
	}
	
	protected void setVehicleModel(String type)
	{
		this.vehicleModel = getValidStringInput("Please enter the Model of the " + type);
	}
	
	protected void setVehicleYear(String type)
	{
		this.vehicleYear = Main.getValidIntegerInput("Please enter the Year of the " + type, 1900, 2100);
	}
	
	protected void setVehicleColor(String type)
	{
		this.vehicleColor = getValidStringInput("Please enter the Color of the " + type);
	}
	
	protected void setVehiclePrice(String type)
	{
		this.vehiclePrice = getValidDoubleInput("Please enter the Price of the " + type, 0, 10000000);
	}
	
	
	//accessors-getters
	public String getVehicleMake()
	{
		return vehicleMake;
	}
	
	public String getVehicleModel()
	{
		return vehicleModel;
	}
	
	public int getVehicleYear()
	{
		return vehicleYear;
	}
	
	public String getVehicleColor()
	{
		return vehicleColor;
	}
	
	public double getVehiclePrice()
	{
		return vehiclePrice;
	}
    
	
	//method to validate string inputs
	private String getValidStringInput(String prompt)
	{
		//infinite loop until a valid string is returned or until user hits cancel
		while (true)
		{
			String userInput = JOptionPane.showInputDialog(null, prompt, "Question", JOptionPane.QUESTION_MESSAGE);
			
			//calls the main menu if user hits cancel or 'x'
			if (userInput == null)
			{
				Main.mainMenu();
				return null;
			}
			
			//verifies that the user input something
			if (!userInput.trim().isEmpty())
			{
				return userInput.trim();
			}
			//displays error if user did not input anything
			JOptionPane.showMessageDialog(null, "Invalid Input\n\nField cannot be left blank", "Error", 				JOptionPane.ERROR_MESSAGE);
		}
	}
	
	
	//method to validate double inputs
	protected static double getValidDoubleInput(String prompt, double min, double max)
	{
		//infinite loop until a valid double is returned or until user hits cancel
		while (true)
		{
			String userInput = JOptionPane.showInputDialog(null, prompt, "Question", JOptionPane.QUESTION_MESSAGE);
			
			//calls the main menu if user hits cancel or 'x'
			if (userInput == null)
			{
				Main.mainMenu();
				return -1;
			}
			
			//verifies that the user input something
			if (userInput.trim().isEmpty())
			{
				//displays error if user did not input anything
				JOptionPane.showMessageDialog(null, "Invalid Input\n\nField cannot be left blank", "Error", 					JOptionPane.ERROR_MESSAGE);
				continue; //if user input was empty, returns to the beginning of the loop
			}
			
			//verifies that the user input a double
			try
			{
				double number = Double.parseDouble(userInput.trim());
				//verifies the double was within the acceptable range
				if (number >= min && number <= max)
				{
					return number;
				}
				else //displays error if the input was out of range
				{
					JOptionPane.showMessageDialog(null, "Invalid Input\n\nPlease enter a number between " + min +
						" and " + max, "Error", JOptionPane.WARNING_MESSAGE);
				}
			}
			catch (NumberFormatException e) //displays error if the user did not input a double
			{
				JOptionPane.showMessageDialog(null,  "Invalid Input\n\nPlease enter a valid number", "Error", 					JOptionPane.ERROR_MESSAGE);
			}
		}
	}
}
