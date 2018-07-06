using System;

class Solution {

    // Complete the solve function below.
    static double solve(double meal_cost, double tip_percent, double tax_percent) {
        double totalCost = (meal_cost +(meal_cost*tip_percent)+(meal_cost*tax_percent));
        return totalCost;
    }

    static void Main(string[] args) 
    { 
        double meal_cost = 12.00;
        double tip_percent = .2;
        double tax_percent = .08;
        double result= solve(meal_cost, tip_percent, tax_percent);
            Console.WriteLine("The total meal cost is ${0:0.00}.", result);
    }
}