﻿using AmdarisAssignment3.Service;

var rideService = new RideService();
var userService = new UserService();

userService.CreateUser("Passenger1", "p1.example@gmail.com", "Card");
userService.CreateUser("Passenger2", "p2.example@gmail.com", "Card");
userService.CreateUser("Driver1", "d1.example@gmail.com", "Toyota","123AAA");

var driver = userService.FindUser("d1.example@gmail.com");
var passenger1 = userService.FindUser("p1.example@gmail.com");
var passenger2 = userService.FindUser("p2.example@gmail.com");

rideService.CreateRide(  "Comrat", owner: driver, destinationTo: "Chisinau", availableSeats: 1);
rideService.CreateRide(  "Cahul", owner: driver, destinationTo: "Chisinau");

var ride1 = rideService.FindRide(1);
var ride2 = ride1.Clone();

Console.WriteLine(ride1 == ride2);

