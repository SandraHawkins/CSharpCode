// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


for (int a = 1; a <= 2; a++)
{
	for (int b = 3; b <= 9; b++)
	{
		for (int c = 5; c <= 9; c++)
		{
			for (int d = 2; d <= 9; d++)
			{
				for (int e = 7; e <= 9; e++)
				{
					for (int f = 5; f <= 9; f++)
					{

						int total = a*6 + b*5 + c*4 + d*3 + e*2 + 1*f;
						if (total % 11 == 0)
						{
                            Console.WriteLine($"{a}{b}{c}{d}{e}{f}");
						}
					}
				}
			}
		}
	}
}
