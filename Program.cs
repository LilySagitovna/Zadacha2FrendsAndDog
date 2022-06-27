// Задача про двух друзей и собаку.
//Сколько раз собака перебежит от одного друга до другого, пока они не встретятся?
int FerstFrendSpeed = 1;
int SecondFrendSpeed = 2;
int dogSpeed = 5;
int distance = 10000;
int friend = 2;//идет ко второму другу
int count = 0;
int time = 0;

while (distance > 10)
{
    if (friend == 1)//идет к первому другу 
    {
        time = distance / (FerstFrendSpeed + dogSpeed);
        friend = 2;
    }
       else
    {
     time = distance / (SecondFrendSpeed + dogSpeed);
     friend = 1;
    }
distance = distance - (FerstFrendSpeed + SecondFrendSpeed) * time;
count++;
}
Console.Write("Собака пробежит ");
Console.WriteLine(count);
Console.Write("раз.");
          