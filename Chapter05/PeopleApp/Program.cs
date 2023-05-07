﻿using Packt.Shared;

Person bob = new ();
WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime(1999, 1, 31);
bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
bob.BucketList = (WondersOfTheAncientWorld)18;

WriteLine("{0} was born on {1:dddd, d MMMM yyyy}.", bob.Name, bob.DateOfBirth);
WriteLine("{0}'s favorite Wonder is {1}. Its integer is {2}", bob.Name, bob.FavoriteAncientWonder, (int)bob.FavoriteAncientWonder);
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}"); bob.Children.Add(new Person { Name = "Alfred" }); // C# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" }); // C# 9.0 and later

WriteLine($"{bob.Name} has {bob.Children.Count} children:");
for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7) // C# 9.0 or later
};

WriteLine("{0} was born on {1:dd MMM yy}", alice.Name, alice.DateOfBirth);