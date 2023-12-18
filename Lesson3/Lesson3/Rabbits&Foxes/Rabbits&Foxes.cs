int rabbits = 100;
double rabbitBirthRate = 0.2;
double foxKillRate = 0.005;
int rabbitsPrev = rabbits;
int rabbitsNext = rabbits;


int foxes = 10;
double foxBirthRate = 0.001;
double foxDeathRate = 0.2;
int foxesPrev = foxes;
int foxesNext = foxes;


for (int i = 0; i <= 1000; i++)
{
    Console.WriteLine($"Year {i}. Rabbits: {(rabbitsNext < 0 ? 0 : rabbitsNext)}, Foxes: {(foxesNext < 0 ? 0 : foxesNext)}");
    rabbitsNext = rabbitsPrev + (int)Math.Round(rabbitsPrev * rabbitBirthRate) - (int)Math.Round(rabbitsPrev * foxesPrev * foxKillRate);
    foxesNext = foxesPrev - (int)Math.Round((double)(foxesPrev * foxDeathRate)) + (int)Math.Round(foxBirthRate * foxesPrev * rabbitsPrev);

    rabbitsPrev = (int)rabbitsNext;
    foxesPrev = (int)foxesNext;
}

// from 89 rabbits 0 foxes 2


