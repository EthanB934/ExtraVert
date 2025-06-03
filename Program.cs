List<Plant> Plants = new List<Plant>()
{
    new Plant()
    {
      Species = "Rose",
      LightNeeds = 3.33,
      AskingPrice = 22.89M,
      City = "New York City",
      ZIP = "100011",
      Sold = true,
    },
    new Plant()
    {
      Species = "Tulip",
      LightNeeds = 2.5,
      AskingPrice = 15.00M,
      City = "Portland",
      ZIP = "97201",
      Sold = false,
    },
    new Plant()
    {
      Species = "Orchid",
      LightNeeds = 4.0,
      AskingPrice = 30.50M,
      City = "Miami",
      ZIP = "33101",
      Sold = false,
    },
    new Plant()
    {
      Species = "Cactus",
      LightNeeds = 5.0,
      AskingPrice = 12.75M,
      City = "Phoenix",
      ZIP = "85001",
      Sold = true,
    },
    new Plant()
    {
      Species = "Fern",
      LightNeeds = 1.5,
      AskingPrice = 18.20M,
      City = "Seattle",
      ZIP = "98101",
      Sold = false,
    },
    new Plant()
    {
      Species = "Bamboo",
      LightNeeds = 3.0,
      AskingPrice = 25.00M,
      City = "San Francisco",
      ZIP = "94101",
      Sold = false,
    },
    new Plant()
    {
      Species = "Succulent",
      LightNeeds = 4.5,
      AskingPrice = 10.99M,
      City = "San Diego",
      ZIP = "92101",
      Sold = true,
    },
    new Plant()
    {
      Species = "Palm",
      LightNeeds = 4.2,
      AskingPrice = 40.00M,
      City = "Los Angeles",
      ZIP = "90001",
      Sold = false,
    },
    new Plant()
    {
      Species = "Lavender",
      LightNeeds = 3.8,
      AskingPrice = 16.50M,
      City = "Austin",
      ZIP = "73301",
      Sold = false,
    },
    new Plant()
    {
      Species = "Aloe Vera",
      LightNeeds = 4.7,
      AskingPrice = 13.45M,
      City = "Las Vegas",
      ZIP = "88901",
      Sold = true,
    },

};

Console.WriteLine(@"

    Welcome to ExtraVert, an online business where others can sell their plants!
    Be sure to view our selection from people like you from around the nation!

");

Console.WriteLine(@"Press enter to continue to view the list of our products...

        0. View All Products
        1. Post a Plant
        2. Adopt a Plant
        3. Delist a Plant
        4. Exit

");
int response = int.Parse(Console.ReadLine().Trim());

while (response < 0 || response > 4)
{

    Console.WriteLine(@"Press select an option from 0 to 4

        0. View All Products
        1. Post a Plant
        2. Adopt a Plant
        3. Delist a Plant
        4. Exit

    ");

    response = int.Parse(Console.ReadLine().Trim());
}

if (response == 0)
{
    Console.WriteLine($@"
        
    =============== All Products: ==============
        ");

    for (int i = 0; i < Plants.Count; i++)
    {
        Console.WriteLine($"\t\t {i + 1}. {Plants[i].Species} --- ${Plants[i].AskingPrice}");
    }
}

