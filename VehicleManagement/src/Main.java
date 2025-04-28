//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import javax.swing.JOptionPane;


public class Main
{
	
	public static void main(String[] args)
	{		
		displayTitleScreen(); //display the opening title screen
		
		loadSomeVehicles(); //load some pre-existing vehicles into the lists
		
		mainMenu(); //display the main menu
	}
	
	
	//method to display the opening title screen
	public static void displayTitleScreen()
	{
		JOptionPane.showMessageDialog(null,
				" ********************************************************************" +
				"\n*                                                                                              *" +
				"\n*                 DMS Vehicle Management System                 *" +
				"\n*                     created by: CodeMonkeyDan                      *" +
				"\n*                                                                                              *" +
				"\n *******************************************************************");		
	}
	
	
	//method to display the main menu
	public static void mainMenu()
	{
		//asks user what they would like to do and loops until they exit the program
		int userDo;
		while (true)
		{
			userDo = getValidIntegerInput("What would you like to do?"
					+ "\n\nPress '1' to add a new vehicle"
					+ "\nPress '2' to see a list of vehicles"
					+ "\nPress '3' to exit progam", 1, 3);
			
			//switches user input to appropriate method
			switch (userDo)
			{
				case 1:
					VehicleManager.addVehicle(); //choose a type and add a vehicle
					break;
				case 2:
					VehicleManager.displayVehicles(); //choose a type and display a list of vehicles
					break;
				case 3:
					EndProgram(); //end the program
					break;
			}	
		}
	}
	
	
	//method to validate integer inputs
	protected static int getValidIntegerInput(String prompt, int min, int max)
	{
		//infinite loop until a valid integer is returned or until user hits cancel
		while (true)
		{
			String userInput = JOptionPane.showInputDialog(null, prompt, "Question", JOptionPane.QUESTION_MESSAGE);
			
			//calls the main menu if user hits cancel or 'x'
			if (userInput == null)
			{
				mainMenu();
				return -1;
			}
			
			//verifies that the user input something
			if (userInput.trim().isEmpty())
			{
				//display error if the user did not input anything
				JOptionPane.showMessageDialog(null, "Invalid Input\n\nField cannot be left blank", "Error", 					JOptionPane.ERROR_MESSAGE);
				continue; //if  userInput was empty, returns to the beginning of the loop
			}

			//verifies that the user input an integer
			try
			{
				int number = Integer.parseInt(userInput.trim());
				//verifies the integer was within the acceptable range
				if (number >= min && number <= max)
				{
					return number;
				}
				else //displays error if input was out of range
				{
					JOptionPane.showMessageDialog(null, "Invalid Input\n\nPlease enter a number between " + min +
						" and " + max, "Error", JOptionPane.WARNING_MESSAGE);
				}
			}
			catch (NumberFormatException e) //displays error if user did not input an integer
			{
				JOptionPane.showMessageDialog(null,  "Invalid Input\n\nPlease enter a valid number", "Error", 					JOptionPane.ERROR_MESSAGE);
			}
		}
	}
	
	
	//method to load some pre-existing vehicles into the lists
	public static void loadSomeVehicles()
	{
		//add 4 cars
		Car newCar = new Car("Pontiac", "GTO Judge", 1969, "Orange", 118400, 2, false);
		Vehicle.allVehicles.add(newCar);
		Car.allCars.add(newCar);
		newCar = new Car("Chevrolet", "Corvette", 2022, "Yellow", 68400, 2, true);
		Vehicle.allVehicles.add(newCar);
		Car.allCars.add(newCar);
		newCar = new Car("Ford", "Mustang GT", 2012, "Black", 35800, 2, false);
		Vehicle.allVehicles.add(newCar);
		Car.allCars.add(newCar);
		newCar = new Car("Lamborghini", "Countach", 1988, "White", 519000, 2, false);
		Vehicle.allVehicles.add(newCar);
		Car.allCars.add(newCar);
		
		//add 3 trucks
		Truck newTruck = new Truck("Ford", "F250", 1988, "Brown", 14331, 8, 12500);
		Vehicle.allVehicles.add(newTruck);
		Truck.allTrucks.add(newTruck);
		newTruck = new Truck("Chevrolet", "1500", 1992, "Grey", 3800, 6, 7500);
		Vehicle.allVehicles.add(newTruck);
		Truck.allTrucks.add(newTruck);
		newTruck = new Truck("Ford", "F150 Raptor", 2023, "Blue", 74988, 6, 8200);
		Vehicle.allVehicles.add(newTruck);
		Truck.allTrucks.add(newTruck);
		
		//add 2 suvs
		SUV newSUV = new SUV("Jeep", "Grand Wagoneer", 2024, "Black", 103530, 8, true);
		Vehicle.allVehicles.add(newSUV);
		SUV.allSUVs.add(newSUV);
		newSUV = new SUV("Honda", "CR-V", 2018, "Silver", 17525, 5, false);
		Vehicle.allVehicles.add(newSUV);
		SUV.allSUVs.add(newSUV);
		
		//add 2 motorcycles
		Motorcycle newMotorcycle = new Motorcycle("Harley Davidson", "Softail Custom", 2010, "Black", 8500, 1584, 			false);
		Vehicle.allVehicles.add(newMotorcycle);
		Motorcycle.allMotorcycles.add(newMotorcycle);
		newMotorcycle = new Motorcycle("Ural", "M-72", 1942, "Tan", 13500, 746, true);
		Vehicle.allVehicles.add(newMotorcycle);
		Motorcycle.allMotorcycles.add(newMotorcycle);
		
		//add 1 rv
		RV newRV = new RV("Airstream", "Ambassador", 1977, "Stainless Steel", 17775, 29, 4);
		Vehicle.allVehicles.add(newRV);
		RV.allRVs.add(newRV);
		
		//add 1 boat
		Boat newBoat = new Boat("Tracker", "Nitro Z21", 2018, "Metallic Red", 34995, 21, 300);
		Vehicle.allVehicles.add(newBoat);
		Boat.allBoats.add(newBoat);
	}
	
	
	//thank user and exit program
	public static void EndProgram()
	{
		JOptionPane.showMessageDialog(null,
				"<html>Thank you for choosing the DMS Vehicle Management System!" +
				"<br><br>created by: <i>CodeMonkeyDan</i>");
		System.exit(0);
	}
}
