List<Video> videos = new List<Video>();

//  Video 1
Video video1 = new Video("How to Bake Sourdough Bread", "Baking with Dana", 842);
video1.AddComment(new Comment("Chris", "This finally worked for me, thank you!"));
video1.AddComment(new Comment("Priya", "What hydration level is your starter?"));
video1.AddComment(new Comment("Marcus", "The crumb on that loaf looks amazing."));
videos.Add(video1);

// Video 2 
Video video2 = new Video("Beginner Guitar Chords", "Strum School", 615);
video2.AddComment(new Comment("Jamie", "Finally a video that explains barre chords clearly."));
video2.AddComment(new Comment("Alex", "Can you do a follow-up on fingerpicking?"));
video2.AddComment(new Comment("Noor", "My fingers hurt but this helped a lot."));
video2.AddComment(new Comment("Devon", "Subscribed after this one video."));
videos.Add(video2);

//  Video 3
Video video3 = new Video("Building a Budget Gaming PC", "TechBench", 1204);
video3.AddComment(new Comment("Sam", "The price breakdown was super helpful."));
video3.AddComment(new Comment("Elena", "Would this build handle 1440p okay?"));
video3.AddComment(new Comment("Théo", "Great video, very clear step by step."));
videos.Add(video3);

// Video 4
Video video4 = new Video("30-Minute Morning Yoga Flow", "Calm Roots Yoga", 1830);
video4.AddComment(new Comment("Ravi", "Perfect way to start the day."));
video4.AddComment(new Comment("Hannah", "Loved the pacing, not rushed at all."));
video4.AddComment(new Comment("Liu", "Do you have a longer version of this flow?"));
videos.Add(video4);

// Display every video and its comments 
foreach (Video video in videos)
{
    Console.WriteLine($"Title: {video.GetTitle()}");
    Console.WriteLine($"Author: {video.GetAuthor()}");
    Console.WriteLine($"Length: {video.GetLength()} seconds");
    Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
    Console.WriteLine("Comments:");

    foreach (Comment comment in video.GetComments())
    {
        Console.WriteLine($"  {comment.GetName()}: {comment.GetText()}");
    }

    Console.WriteLine();
} 