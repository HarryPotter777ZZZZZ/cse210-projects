public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private Queue<string> _shuffledPrompts;
    private Queue<string> _shuffledQuestions;

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _shuffledPrompts = new Queue<string>(_prompts.OrderBy(x => Guid.NewGuid()));
        _shuffledQuestions = new Queue<string>(_questions.OrderBy(x => Guid.NewGuid()));
    }

    public override void Run()
    {
        DisplayStartingMessage();
        string prompt = GetNextPrompt();
        Console.WriteLine(prompt);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            string question = GetNextQuestion();
            Console.WriteLine(question);
            ShowSpinner(3);
        }

        DisplayEndingMessage();
    }

    private string GetNextPrompt()
    {
        if (_shuffledPrompts.Count == 0)
        {
            _shuffledPrompts = new Queue<string>(_prompts.OrderBy(x => Guid.NewGuid()));
        }
        return _shuffledPrompts.Dequeue();
    }

    private string GetNextQuestion()
    {
        if (_shuffledQuestions.Count == 0)
        {
            _shuffledQuestions = new Queue<string>(_questions.OrderBy(x => Guid.NewGuid()));
        }
        return _shuffledQuestions.Dequeue();
    }
}