using System;

// Exceeding Requirements
// Implemented a level system that works as follows:
// - Players gain levels based on their total points, every 1000 points = 1 level
// - Each level has a special title inspired by gospel principles (but they're also funny :P):
//   * Level 1: "Child of God"
//   * Level 2: "Telestial Master"
//   * Level 3: "Terrestrial Master"
//   * Level 4: "Disciple of Christ"
//   * Level 5: "Saint"
//   * Levels 6-9: "Good and Faithful Servant"
//   * Level 10+: "Celestial Grand Master"
// - Also added a visual "LEVEL UP!" message with border art when advancing to a new level
// - The current level and title are also displayed with score in the player info section

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}