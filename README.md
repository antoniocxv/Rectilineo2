# Rectilinear2
Second practice of Rectilinear Movement

## 1. Rotate to the objetive and go foward till the objetive
![exercise 1](https://github.com/antoniocxv/Rectilineo2/blob/main/gifs/ejercicio1.gif)
In this case the sheep is going to reach the rock. Script: Go Forward.
<img width="auto" alt="image" src="https://github.com/antoniocxv/Rectilineo2/assets/6523949/68cb6365-b5c6-4a96-95cd-9ad8fd3ed8bc">
We need to calculate the distance to the objective, and then verify if the margin of the jitter is right. If it is all fine, the next step is normalizing the direction to avoid the influence of the magnitude of the vector. After that, it is necessary to estimate the rotacion, and finally apply a soft rotation and the movement to our destiny.

## 2. Doing the same introducing LookAt function and Wuarternion.Slerp
![exercise 2](https://github.com/antoniocxv/Rectilineo2/blob/main/gifs/ejercicio2.gif)
The problem is the same, but resolve in another way. Script: softCurve.
<img width="auto" alt="image" src="https://github.com/antoniocxv/Rectilineo2/assets/6523949/4abc84b1-d355-406e-a04a-42efb177c384">
Now, the solution is provided by calculating the direction to the objetive, and applying "LookRotation and Slerp" methods from the Quaternion class.

## 3. Basic waypoints. Select different objects to create the circuit
![exercise 3](https://github.com/antoniocxv/Rectilineo2/blob/main/gifs/ejercicio3.gif)
 With the previous code, we have added three different objetives to make a circuit. Script: waypoint
<img width="auto" alt="image" src="https://github.com/antoniocxv/Rectilineo2/assets/6523949/4c006648-8624-44ba-ba5b-1d78b86fc24f">
Being targets the list of objects (transforms) that we have chosen, the sheep is going to visit from one to the next, and when it has finished, it will go to the first object. To do that we main in focus the distance between the object and the sheep, and if it is very near, it will change to the next point. In this example, there are 3 rocks that define the waypoint, when the sheep reach the third one, it retuns to the first

## 4. and 5. Using WaypointProgressTracker and controlling with arrow keys
![exercise 4 and 5](https://github.com/antoniocxv/Rectilineo2/blob/main/gifs/ejercicio5.gif)
In this case we have changed the scenario because of, there where something wrong with the previous one and the behaviour was not as expected. Script: CircleMovement and the help of the scripts "WaypointCircuit" y "WayPointProgressTracker"
<img width="auto" alt="image" src="https://github.com/antoniocxv/Rectilineo2/assets/6523949/14c7a0e2-3a00-4208-a6a8-9be8dbeaaed6">
In this final exercise, the script has been minimun, just a simple one to control the sphere with the arrows. The issue in this practice is to configure a circuit. To do that, we need to create an empty object, and later create different transforms (as points) as their children, finally, we need to attach the "waypointCircuit" script to the father. When we associate the waypoint progress tracker to the sphere, and telling the target is the cube, the cube will run away from the sphere following the path we have created in the circuit
 
