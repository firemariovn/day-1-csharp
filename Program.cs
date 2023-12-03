using System;

string[] inputString = File.ReadAllLines("input.txt");
int firstNumber = -1;
int lastNumber = -1;
int finalResult = 0;

foreach (string line in inputString) {
    firstNumber = -1;
    for (int index = 0; index < line.Length; index++) {
        if (Char.IsDigit(line, index)) {
            if (firstNumber >= 0) {
                lastNumber = Int32.Parse(line.Substring(index, 1));
            } else {
                firstNumber = Int32.Parse(line.Substring(index, 1));
                lastNumber = Int32.Parse(line.Substring(index, 1));
            }
        }
    }
    if (firstNumber <= 0) {
        Console.WriteLine($"There is no number in this line: {line}");
        continue;
    }
    finalResult += (firstNumber * 10) + lastNumber;
}

Console.WriteLine($"Dap an cuoi cung cua em la: {finalResult} !");