const string Rock = "Rock";
const string Paper = "Paper";
const string Scissors = "Scissors";

Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
string playerMove = Console.ReadLine();
if (playerMove == "rock" || playerMove == "r")
{
    playerMove = Rock;
}
else if (playerMove == "s" || playerMove == "scissors")
{
    playerMove = Scissors;
}
else if (playerMove == "p" || playerMove == "paper")
{
    playerMove = Paper;
}
else
{
    Console.WriteLine("Invalid Input. Try again...");
    return;
}

Random random = new Random();
int computerRandomNumber = random.Next(1, 4);

string computerMove = "";
switch (computerRandomNumber)
{
    case 1:
        computerMove = Rock; break;
    case 2:
        computerMove = Scissors; break;
    case 3:
        computerMove = Paper; break;
}
Console.WriteLine($"The computer chose {computerMove}.");
if ((playerMove == Rock && computerMove == Scissors) ||
    (playerMove == Scissors && computerMove == Paper) ||
    (playerMove == Paper && computerMove == Rock))
{
    Console.WriteLine("You win.");
}
else if  ((playerMove == Scissors && computerMove == Rock) ||
    (playerMove == Rock && computerMove == Paper) ||
    (playerMove == Paper && computerMove == Scissors))
{
    Console.WriteLine("You lose.");
}
else Console.WriteLine("This game was a draw.");