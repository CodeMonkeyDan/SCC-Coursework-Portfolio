//Daniel Schiefer aka CodeMonkeyDan
//CPT236-A80S-2025SP
//Lab #5: Vehicle Management System


import javax.swing.JOptionPane;


public class VehicleManager
{
	//add vehicle method
	public static void addVehicle()
	{
		//asks the user what type of vehicle they want to add
		int vehicleType = Main.getValidIntegerInput("What type of vehicle would you like to add?"
				+ "\n\nPress '1' for Car"
				+ "\nPress '2' for Truck"
				+ "\nPress '3' for SUV"
				+ "\nPress '4' for Motorcycle"
				+ "\nPress '5' for RV"
				+ "\nPress '6' for Boat", 1, 6);
		
		//returns to the main menu if the user hits cancel
		if (vehicleType == -1) return;
		
		//switch case based on user selection, used to set type for asking user specific input questions
		String type = "";
		switch (vehicleType)
		{
			case 1:
				type = "Car";
				break;
			case 2:
				type = "Truck";
				break;
			case 3:
				type = "SUV";
				break;
			case 4:
				type = "Motorcycle";
				break;
			case 5:
				type = "RV";
				break;
			case 6:
				type = "Boat";
				break;
		}
		
		//creates a new vehicle and sets the attributes/properties
		Vehicle newVehicle = new Vehicle();
		newVehicle.setVehicleMake(type);
		newVehicle.setVehicleModel(type);
		newVehicle.setVehicleYear(type);
		newVehicle.setVehicleColor(type);
		newVehicle.setVehiclePrice(type);
		//adds new vehicle to vehicle list
		Vehicle.allVehicles.add(newVehicle);

		//switch case based on user selection, used to create subclass objects and lists
		switch (vehicleType)
		{
			case 1: //creates a new car and sets the attributes/properties
				Car newCar = new Car(newVehicle.getVehicleMake(),
						newVehicle.getVehicleModel(),
						newVehicle.getVehicleYear(),
						newVehicle.getVehicleColor(),
						newVehicle.getVehiclePrice());
				newCar.setCarNumDoors(type);
				newCar.setCarIsConvertible(type);
				Car.allCars.add(newCar);
				break;
			case 2: //creates a new truck and sets the attributes/properties
				Truck newTruck = new Truck(newVehicle.getVehicleMake(),
						newVehicle.getVehicleModel(),
						newVehicle.getVehicleYear(),
						newVehicle.getVehicleColor(),
						newVehicle.getVehiclePrice());
				newTruck.setTruckBedLength(type);
				newTruck.setTruckTowingCapacity(type);
				Truck.allTrucks.add(newTruck);
				break;
			case 3: //creates a new suv and sets the attributes/properties
				SUV newSUV = new SUV(newVehicle.getVehicleMake(),
						newVehicle.getVehicleModel(),
						newVehicle.getVehicleYear(),
						newVehicle.getVehicleColor(),
						newVehicle.getVehiclePrice());
				newSUV.setSUVSeatingCapacity(type);
				newSUV.setHasThirdRowSeating(type);
				SUV.allSUVs.add(newSUV);
				break;
			case 4: //creates a new motorcycle and sets the attributes/properties
				Motorcycle newMotorcycle = new Motorcycle(newVehicle.getVehicleMake(),
						newVehicle.getVehicleModel(),
						newVehicle.getVehicleYear(),
						newVehicle.getVehicleColor(),
						newVehicle.getVehiclePrice());
				newMotorcycle.setMotorcycleCC(type);
				newMotorcycle.setMotorcycleHasSideCar(type);
				Motorcycle.allMotorcycles.add(newMotorcycle);
				break;
			case 5: //creates a new rv and sets the attributes/properties
				RV newRV = new RV(newVehicle.getVehicleMake(),
						newVehicle.getVehicleModel(),
						newVehicle.getVehicleYear(),
						newVehicle.getVehicleColor(),
						newVehicle.getVehiclePrice());
				newRV.setRVLength(type);
				newRV.setRVSleepingCapacity(type);
				RV.allRVs.add(newRV);
				break;
			case 6: //creates a new boat and sets the attributes/properties
				Boat newBoat = new Boat(newVehicle.getVehicleMake(),
						newVehicle.getVehicleModel(),
						newVehicle.getVehicleYear(),
						newVehicle.getVehicleColor(),
						newVehicle.getVehiclePrice());
				newBoat.setBoatLength(type);
				newBoat.setBoatHP(type);
				Boat.allBoats.add(newBoat);
				break;
		}
	}
	
	
	//display vehicle list method
	public static void displayVehicles()
	{
		//asks the user what type of list they want to display
		int vehicleType = Main.getValidIntegerInput("What type of list would you like to see?"
				+ "\n\nPress '1' for Car"
				+ "\nPress '2' for Truck"
				+ "\nPress '3' for SUV"
				+ "\nPress '4' for Motorcycle"
				+ "\nPress '5' for RV"
				+ "\nPress '6' for Boat"
				+ "\nPress '7' for All Vehicles", 1, 7);
		
		//returns to the main menu if the user hits cancel
		if (vehicleType == -1) return;
		
		//string type is used to create more specific text to user
		String type = "";
		//string builder to create the lists
		StringBuilder displayList = new StringBuilder();
		
		//switch case based on user selection, used to create the selected list
		switch (vehicleType)
		{
			case 1: //creates a list of all the cars
				type = "Car";
				for (var car : Car.allCars)
				{
					displayList.append(car.getVehicleYear() + " " +
							car.getVehicleColor() + " " +
							car.getVehicleMake() + " " +
							car.getVehicleModel() + " - " +
							car.getCarNumDoors() + " Door " +
							(car.getCarIsConvertible() ? "Convertible" : "Hardtop") +
							", Valued at $" + String.format("%, .2f", car.getVehiclePrice()) + "\n");
				}
				break;
			case 2: //creates a list of all the trucks
				type = "Truck";
				for (var truck : Truck.allTrucks)
				{
					displayList.append(truck.getVehicleYear() + " " +
							truck.getVehicleColor() + " " +
							truck.getVehicleMake() + " " +
							truck.getVehicleModel() + " - " +
							truck.getTruckBedLength() + "' Bed & " +
							truck.getTruckTowingCapacity() + " lb. Towing Capacity" +
							", Valued at $" + String.format("%, .2f", truck.getVehiclePrice()) + "\n");
				}
				break;
			case 3: //creates a list of all the suvs
				type = "SUV";
				for (var suv : SUV.allSUVs)
				{
					displayList.append(suv.getVehicleYear() + " " +
							suv.getVehicleColor() + " " +
							suv.getVehicleMake() + " " +
							suv.getVehicleModel() + " - " +
							"Seats " + suv.getSUVSeatingCapacity() +
							(suv.getHasThirdRowSeating() ? " w/ Third Row Seating" : "w/o Third Row Seating") +
							", Valued at $" + String.format("%, .2f", suv.getVehiclePrice()) + "\n");
				}
				break;
			case 4: //creates a list of all the motorcycles
				type = "Motorcycle";
				for (var motorcycle : Motorcycle.allMotorcycles)
				{
					displayList.append(motorcycle.getVehicleYear() + " " +
							motorcycle.getVehicleColor() + " " +
							motorcycle.getVehicleMake() + " " +
							motorcycle.getVehicleModel() + " - " +
							motorcycle.getMotorcycleCC() + "cc Motor" +
							(motorcycle.getMotorcycleHasSideCar() ? " w/ Side Car" : " w/o Side Car") +
							", Valued at $" + String.format("%, .2f", motorcycle.getVehiclePrice()) + "\n");
				}
				break;
			case 5: //creates a list of all the rvs
				type = "RV";
				for (var rv : RV.allRVs)
				{
					displayList.append(rv.getVehicleYear() + " " +
							rv.getVehicleColor() + " " +
							rv.getVehicleMake() + " " +
							rv.getVehicleModel() + " - " +
							rv.getRVLength() + " ft Long " +
							"& Sleeps " + rv.getRVSleepingCapacity() +
							", Valued at $" + String.format("%, .2f", rv.getVehiclePrice()) + "\n");
				}
				break;
			case 6: //creates a list of all the boats
				type = "Boat";
				for (var boat : Boat.allBoats)
				{
					displayList.append(boat.getVehicleYear() + " " +
							boat.getVehicleColor() + " " +
							boat.getVehicleMake() + " " +
							boat.getVehicleModel() + " - " +
							boat.getBoatLength() + " ft Long " +
							boat.getBoatHP() + "hp"+
							", Valued at $" + String.format("%, .2f", boat.getVehiclePrice()) + "\n");
				}
				break;
			case 7: //creates a list of all the vehicles
				type = "Vehicle";
				for (var vehicle : Vehicle.allVehicles)
				{
					displayList.append(vehicle.getVehicleYear() + " " +
							vehicle.getVehicleColor() + " " +
							vehicle.getVehicleMake() + " " +
							vehicle.getVehicleModel() +
							", Valued at $" + String.format("%, .2f", vehicle.getVehiclePrice()) + "\n");
				}
				break;
		}
		
		//checks if the selected list is empty or not
	    if (!displayList.isEmpty())
	    {
	        JOptionPane.showMessageDialog(null, displayList, type + " List", JOptionPane.INFORMATION_MESSAGE);
	    }
	    else
	    {
	        JOptionPane.showMessageDialog(null, "No list to display.", type + " List", 				JOptionPane.INFORMATION_MESSAGE);
	    }
	}
}
