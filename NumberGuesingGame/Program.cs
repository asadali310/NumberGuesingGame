
int minNumber = 1;
int maxNumber = 20;

// Generate a random number between minNumber and maxNumber (inclusive)
Random random = new Random();
int randomNumber = random.Next(minNumber, maxNumber + 1);

int guess;
int attempts = 0;
bool isCorrect = false;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine($"I have chosen a number between {minNumber} and {maxNumber}.");

while (!isCorrect)
{
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();
  
    // Check if the input is a valid integer
    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
        continue;
    }

    attempts++;

    if (guess < randomNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (guess > randomNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }
    else
    {
        isCorrect = true;
    }
}

Console.WriteLine($"Congratulations! You guessed the correct number {randomNumber} in {attempts} attempts.");
