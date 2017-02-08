using System;
using System.Linq;

class Person{
	protected string firstName;
	protected string lastName;
	protected int id;
	
	public Person(){}
	public Person(string firstName, string lastName, int identification){
			this.firstName = firstName;
			this.lastName = lastName;
			this.id = identification;
	}
	public void printPerson(){
		Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id); 
	}
}
// SOLUTION START //
class Student : Person{
    private int[] testScores;
    public Student(string firstName, string lastName, int identification, int[] testScores) : base(firstName, lastName,               identification)
    {
        this.testScores = testScores;
    }
    
    public char calculate(){
        int x = 0;
        for (int i = 0;i<testScores.Length;i++) {
            x = x + testScores[i]; 
        }
        x = (x/testScores.Length);
        
        if (x <=100 && x >= 90) {
            return 'O';
        }
        else if (x <= 89 && x >= 80) {
            return 'E';
        }
        else if (x <= 79 && x >= 70) {
            return 'A';
        }
        else if (x <= 69 && x >= 55) {
            return 'P';
        }
        else if (x <= 54 && x >= 40) {
            return 'D';
        }
        else {
            return 'T';
        }
    }
  
}
// SOLUTION END
class Solution {
	static void Main() {
		string[] inputs = Console.ReadLine().Split();
		string firstName = inputs[0];
	  	string lastName = inputs[1];
		int id = Convert.ToInt32(inputs[2]);
		int numScores = Convert.ToInt32(Console.ReadLine());
		inputs = Console.ReadLine().Split();
	  	int[] scores = new int[numScores];
		for(int i = 0; i < numScores; i++){
			scores[i]= Convert.ToInt32(inputs[i]);
		} 
	  	
		Student s = new Student(firstName, lastName, id, scores);
		s.printPerson();
		Console.WriteLine("Grade: " + s.calculate() + "\n");
	}
}