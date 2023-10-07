

class Calculator{

public int answer;
    
    public static void Main(string[] args){
        var f = new Calculator();
        f.FunctionCheck();          
    }

    void FunctionCheck(){
        Console.WriteLine("Please enter your first number");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter which operation you would like to use");
        string input = Console.ReadLine()!;
        Console.WriteLine("Please enter a second number");
        int num2 = Convert.ToInt32(Console.ReadLine());
     
        switch(input){
                case "addition":
                Addition(num1,num2);
                
                break;
                case "subtraction":
                Subtraction(num1, num2);
                
                break;
                case "multiplicaton":
                Multiplication(num1,num2);
                
                break;
                case "division":
                Division(num1,num2);
                
                break;
        }
        Console.WriteLine("Answer is: "+ answer);

    }

    public void Addition(int num1, int num2){
            answer = num1 + num2;
            return;

    }
    public  void Subtraction(int num1, int num2){
            answer = num1 - num2;
            return;
    }

    public  void Multiplication(int num1, int num2){
             answer = num1 * num2;
             return;
    }

    public void Division(int num1, int num2){
            answer = num1/num2;
            return;
    }

}
