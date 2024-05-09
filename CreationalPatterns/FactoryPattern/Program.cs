using FactoryPattern;

VehicleFactory vehicleFactory = new VehicleFactory();

IVehicle car = vehicleFactory.CreateVehicle("car");
car.Drive();

IVehicle truck = vehicleFactory.CreateVehicle("truck");
truck.Drive();

