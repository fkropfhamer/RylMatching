// See https://aka.ms/new-console-template for more information


string path = Environment.GetCommandLineArgs()[1];

Console.WriteLine(path);
RylMatching.MatchingAlgorithm.test();
RylMatching.MatchingAlgorithm.ReadMentorCsv(path);