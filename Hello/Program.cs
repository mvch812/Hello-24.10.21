// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача: два друга идут навстречу друг другу. От одного к другому бегает собака. Вопрос: сколько раз собака сбегает от одного
//к другому пока они не встретятся?

int count = 0;
int distance = 10000;
int FirstFriendSpeed =1;
int SecondFriendSpeed = 2;
int dogSpeed = 5;
int friend = 2;
int time = 0;
while (distance > 10)
{
    if (friend == 1)
    {

        time = distance/( FirstFriendSpeed + dogSpeed );
        friend = 2;
    }
    else
    {
        time = distance/( SecondFriendSpeed + dogSpeed );
        friend = 1;
    }
distance = distance - (FirstFriendSpeed + SecondFriendSpeed)* time;
count++;

}

Console.WriteLine(count);