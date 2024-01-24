Random coin = new Random();
int flip = coin.Next(0, 1);
Console.WriteLine((flip == 0) ? "heads" : (flip == 1)? "tails" : "nothing");