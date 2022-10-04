# Exercises lesson 4

## Exercise 1
Create 3 controllers named as follow:<br/>
1. UserController
2. VehicleController
3. FactoryController

They all have an action which returns a string containing the name of the controller.<br/>
All the actions are of the HTTP action type GET.

## Exercise 2
Add an action in the user controller where you need to give a number, which represents 'age'.<br/>
If it is lower than a 18, return a bad request response then.<br/>
Otherwise return a ok response.<br/>
Do the same thing for vehicle controller, but when it is lower than 4, then you need to return a bad request response.<br/>
Both actions are of the HTTP action type POST.

## Exercise 3
Create an action in the user controller which requests a name from the body.<br/>
The action is of the Http action type POST.<br/>
Create also an action in the factory controller which requests a name from the route.<br/>
The action is of the Http action type Get.

## Exercise 4
Try to create a model which represent a user with the following properties:<br/>
- Name: string
- Age: int
- Address: string
- Gender: enumeration

Add an action in the user controller which requests the user model.<br/>
The response of the action is of the type string which tells the info of the user like "Hello my name is ... and I'm from ... ".<br/>
The action has the HTTP action type POST.

## Exercise 5
Add a field to user controller which is a List of the user model created in exercise 4.<br/>
Create an action which search after an user in the list by giving a name to the action.<br/>
The found user is returned back as response.<br/>
The action has the HTTP action type GET.

## Exercise 6
With the list from exercise 5, create an action which put an user in the list.<br/>
The action receives a request which is an user.<br/>
The response is the whole list.<br/>
The action has the HTTP action type POST.

## Exercise 7
Final exercise. This will be divided in multiple parts.

### Part 1
Create a model which represent a vehicle with following properties:<br/>
- LicensePlate: string
- Model: string
- Owner: User (optional)

### Part 2
Add a field to the vehicle controller which contains vehicles with the use of the model before.

### Part 3
Create a model which is the same as in part 1, but has one property less namely Owner.<br/>
Call this model 'VehicleDto'.

### Part 4
Create 4 actions:
1. An action which gets a vehicle from the list.<br/>
   The request is a string with the license plate.<br/>
   The response is the found vehicle.
2. An action which puts a vehicle in the list.
   The request is a vehicle DTO.<br/>
   You will need to create a vehicle model with the properties of the DTO that you send.<br/>
   The reponse is the created vehicle.
3. An action which adds an user to the vehicle in the list.<br/>
   This request contais two parameters, namely the license plate of the vehicle and the Owner.<br/>
   Find the vehicle in the list and add the user to the Owner property.<br/>
   The response is the vehicle with the added user.
4. An action which removes from the list.
   The request is the license plate of the vehicle.<br/>
   Find the vehicle in the list and remove it from the list.<br/>
   Return a model where you show 3 things:
   - The vehicle that is removed
   - The length of the list before the removal
   - The length of the list after the removal

## Questions? Ask right away!
