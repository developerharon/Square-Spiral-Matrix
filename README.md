# Printing a Square Spiral Matrix

## Task
Write a program, which prints a square spiral matrix beginning from the number 1 in the upper right corner and moving clockwise.

## Generating an idea for the solution
### The first idea. 
The first idea was to start filling the cells with numbers from the centre. For an odd number, n, the centre is located in the centre of the matrix, but for an even number the cell is located to the upper left of the centre of the matrix. So the steps to be followed were:
1. Fill the centre cell with n^2
2. If n is an odd number, fill the cells, up, left, down and right else if n is an even number, fill the cells down, right, up and left. 
3. The number of steps to be made in a given direction formed the pattern 1, 1, 2, 2, 3, 3, ..., n-1, n-1, n-1. So for n = 3, we would have 1, 1, 2, 2, 2 and for n = 4 we would have 1, 1, 2, 2, 3, 3, 3 steps following the direction, for an odd n start with up and for an even n start with direction down.

### The second idea.
The second idea was to start with the upper right corner and move clockwise as we fill the matrix. The steps to be followed were:
1. Fill the start cell, upper most corner with the value 1.
2. Move down n - 1 steps. And then reset the steps to be done to be n - 1 and let it change the direction twice before it reducing the steps to be done to n - 2 and so on until we get to 1. By doing this, we ensure that we are going in the pattern n-1, n-1, n-1, ..., 3, 3, 2, 2, 1, 1. So if we have n = 3, we would have 2, 2, 2, 1, 1, and for n = 4 we would have 3, 3, 3, 2, 2, 1, 1. 
3. The next direction would be calculated by incrementing the current direction with one and taking the remainder when divided by 4, this will ensure our number is always either 0, 1, 2 or 3, which respectively represents down, left, up and right.
4. To determine if we need a step change, that is, in the pattern derived above each number, changes after being repeated twice, we add one to the stepchange and get the remainder after dividing it by two. This will ensure our number is always either 0 or 1. If it is one, we decrement the number of steps needed to be performed in a particular direction by one.
5. We loop steps 2, 3 and 4 until we get the number n^2.

## Checking on the ideas
I decided to go with the second idea, because both ideas seems to be the same except the first idea becomes complicated when choosing how for an odd number, we start by going up, while for an even number we go down, i.e. direction wise. 

## Data Structure and Efficiency.
I decided to use an array - two-dimension array- because, it easy to represent a matrix with it. Also in terms of addition of values to the array and access, it seems a fast process for our situation, because we don't deal with big numbers here. 

## Implementation of the idea
1. Fill the current cell with the current number.
2. Check whether the current direction should be changed.
3. Based on the direction, move to the next cell.
4. Print the matrix to the console.
5. Design a way for the user to interact with the program through the console.

## summary
This repository shows my implementation of the solution:

#### Environment used:
Visual Studio 2019, Console app(.NET core 2.2)