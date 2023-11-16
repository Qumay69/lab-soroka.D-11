        Console.Write("Введите текст:");
        string input = Console.ReadLine();
        
        string[] words = input.Split(' ');

        if (words.Length > 1)
        {
            string firstWord = words[0];
            string lastWord = words[words.Length - 1];

            words[0] = lastWord;
            words[words.Length - 1] = firstWord;

            string result = string.Join(" ", words);

            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine(input);
        }